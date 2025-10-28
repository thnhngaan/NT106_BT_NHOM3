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
using Client;
namespace Server
{
    public partial class TCPServer_login : Form
    {
        private TcpListener listener;
        private bool isRunning = false;
        public TCPServer_login()
        {
            InitializeComponent();
        }
        static bool CheckLogin(string username, string hashedPassword)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE USERNAME=@user AND PASSWORD=@pass";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", hashedPassword); // so sánh hash
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void TCPServer_login_Load(object sender, EventArgs e)
        {
            StartServer();
        }
        private void StartServer()
        {   
            listener = new TcpListener(IPAddress.Any, 8080);
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
                bool isLogin = false;
                while (!isLogin && client.Connected)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    string[] parts = data.Split('|', StringSplitOptions.RemoveEmptyEntries);
                    //client gửi msg định dạng {username|password}
                    if (parts.Length < 2)
                    {
                        AppendText($"Client {clientEP} gửi dữ liệu không hợp lệ: {data}");
                        byte[] InvalidData = Encoding.UTF8.GetBytes("Fail: Invalid data");
                        stream.Write(InvalidData, 0, InvalidData.Length);
                        continue;
                    }

                    AppendText("Client (" + clientEP + ") gửi dữ liệu thành công");

                    string username = parts[0];
                    string password = parts[1];

                    string respond = CheckLogin(username, password) ? "Login success" : "Login failed";

                    byte[] responseBytes = Encoding.UTF8.GetBytes(respond);
                    stream.Write(responseBytes, 0, responseBytes.Length);

                    AppendText($"Trạng thái đăng nhập của client ({clientEP}): {respond}");
                    if (CheckLogin(username,password))
                    {
                        isLogin = true;
                        AppendText($"Client ({clientEP}) đăng nhập thành công. Đang đóng kết nối...");
                    }
                    else
                    {
                        AppendText($"Client ({clientEP}) đăng nhập thất bại. Chờ thử lại...");
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
    }
}
