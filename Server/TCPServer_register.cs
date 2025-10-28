using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.Data.SqlClient;
namespace Server
{
    public partial class TCPServer_register : Form
    {
        private TcpListener listener;
        private bool isRunning = false;
        public TCPServer_register()
        {
            InitializeComponent();
            StartServer();
        }

        private bool UsernameExist(string username) //có rồi thì trả về 1 chưa có thì trả về 0
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @user";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                AppendText("Lỗi kiểm tra UsernameExist: " + ex.Message);
                return true; // giả định tồn tại để tránh thêm trùng khi lỗi
            }
        }
        
        private void AddUsertoDatabase(string username, string password,string email,string fullname, string sdt)
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Users (USERNAME, PASSWORD, EMAIL, MOBILENUMBER, FULLNAME) VALUES (@user, @pass, @mail, @phone, @name)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password); // đã là hash từ client
                        cmd.Parameters.AddWithValue("@mail", email);
                        cmd.Parameters.AddWithValue("@name", fullname);
                        cmd.Parameters.AddWithValue("@phone", sdt);

                        cmd.ExecuteNonQuery();
                    }
                }
                AppendText($"✅ Đã thêm user {username} vào database");
            }
            catch (Exception ex)
            {
                AppendText("Lỗi " + ex.Message);
            }
        }
        private void StartServer()
        {
            listener = new TcpListener(IPAddress.Any, 8081);
            listener.Start();
            isRunning = true;

            Task.Run(() => ListenForClient());
        }

        private void ListenForClient()
        {
            while (isRunning)
            {
                TcpClient client = listener.AcceptTcpClient();
                ThreadPool.QueueUserWorkItem(HandleClient, client);
            }
        }
        private void AppendText(string text) //thêm cập nhập của client vào richtextbox thông báo
        {
            if (rtb_servernotify.InvokeRequired)
                rtb_servernotify.Invoke(new Action<string>(AppendText), text);
            else
                rtb_servernotify.AppendText(text + Environment.NewLine);
        }
        private Dictionary<IPEndPoint, IPAddress> connectedClients = new Dictionary<IPEndPoint, IPAddress>();
        private void UpdateClientList() //thêm ip của client đang kết nối vào richtextbox
        {
            if (rtb_clientsconnection.InvokeRequired)
            {
                rtb_clientsconnection.Invoke(new Action(UpdateClientList));
            }
            else
            {
                rtb_clientsconnection.Clear();
                lock (connectedClients)
                {
                    foreach (var keyvalue in connectedClients)
                    {
                        rtb_clientsconnection.AppendText(keyvalue.Value.ToString() + Environment.NewLine);
                    }
                }
            }
        }
        private void HandleClient(object obj)
        {
            TcpClient client = obj as TcpClient;
            if (client == null) return;

            IPEndPoint clientEP = client.Client.RemoteEndPoint as IPEndPoint;

            lock (connectedClients)
            {
                connectedClients[clientEP] = clientEP.Address;
            }
            UpdateClientList();
            AppendText("Client (" + clientEP + ") đã kết nối.");
            AppendText("Server đang chờ dữ liệu từ client: " + clientEP);
            try
            {
                NetworkStream stream = client.GetStream();
                var size = 1024;
                var buffer = new byte[size];
                bool isRegister = false;
                while (!isRegister && client.Connected)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;
                    string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    string[] parts = data.Split('|', StringSplitOptions.RemoveEmptyEntries);
                    if (parts[0] == "INFO" && parts.Length == 2)
                    {
                        string username = parts[1];
                        var info = GetUserInfo(username);

                        string Response;
                        if (info.fullname != null)
                            Response = $"INFO|{username}|{info.fullname}|{info.email}|{info.phone}";
                        else
                            Response = "Fail: User not found";

                        byte[] ResponseBytes = Encoding.UTF8.GetBytes(Response);
                        stream.Write(ResponseBytes, 0, ResponseBytes.Length);
                        continue; // chờ client gửi lệnh khác
                    }
                    //client gửi tới định dạng {username|password|email|fullname|sdt}
                    if (parts.Length < 5)
                    {
                        AppendText($"Client {clientEP} gửi dữ liệu không hợp lệ: {data}");
                        byte[] InvalidData = Encoding.UTF8.GetBytes("Fail: Invalid data");
                        stream.Write(InvalidData, 0, InvalidData.Length);
                        continue;
                    }

                    AppendText("Client (" + clientEP + ") gửi dữ liệu thành công");

                    string Username = parts[0];
                    string Password = parts[1];
                    string Email = parts[2];
                    string Fullname = parts[3];
                    string Sdt = parts[4];

                    bool isUsernameExist = UsernameExist(Username); //cái đoạn này logic hơi ngược tí =)))))
                    string response;
                    if (isUsernameExist)
                        response = "Register failed";
                    else
                    {
                        AddUsertoDatabase(Username, Password, Email, Fullname, Sdt);
                        response = "Register success";
                    }

                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    stream.Write(responseBytes, 0, responseBytes.Length);

                    AppendText($"Trạng thái đăng ký của client ({clientEP}): {response}");
                    if (!isUsernameExist)
                    {
                        isRegister = true;
                        AppendText($"Client ({clientEP}) đăng ký thành công. Đang đóng kết nối...");
                    }
                    else
                    {
                        AppendText($"Client ({clientEP}) đăng ký thất bại. Chờ thử lại...");
                    }
                }
                stream.Close();
                client.Close();
                AppendText($"Client {clientEP} đã thoát kết nối");
                lock (connectedClients)
                {
                    connectedClients.Remove(clientEP);
                }
                UpdateClientList();
            }
            catch (Exception ex)
            {
                AppendText($"Client {clientEP} gặp lỗi: {ex.Message}");
            }
        }
        private (string fullname, string email, string phone) GetUserInfo(string username)
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    string query = "SELECT FULLNAME, EMAIL, MOBILENUMBER FROM Users WHERE USERNAME = @user";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fullname = reader["FULLNAME"].ToString();
                                string email = reader["EMAIL"].ToString();
                                string phone = reader["MOBILENUMBER"].ToString();
                                return (fullname, email, phone);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppendText("Lỗi GetUserInfo: " + ex.Message);
            }
            return (null, null, null); // không tìm thấy
        }
    }
}
