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
            //sql
            return false;
        }
        
        private void AddUsertoDatabase(string username, string password,string email,string fullname, string sdt)
        {
            //sql tiếp nè hihi
            return;
        }
        private void StartServer()
        {
            tb_ipserver.Text = "192.168.156.1";
            var ip = IPAddress.Parse("192.168.156.1"); //sửa lại dùng IPAddress.Any nhen
            listener = new TcpListener(ip, 8081);
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
                    //client gửi tới định dạng {username|password|email|fullname|sdt}
                    if (parts.Length < 5)
                    {
                        AppendText($"Client {clientEP} gửi dữ liệu không hợp lệ: {data}");
                        byte[] InvalidData = Encoding.UTF8.GetBytes("Fail: Invalid data");
                        stream.Write(InvalidData, 0, InvalidData.Length);
                        continue;
                    }

                    AppendText("Client (" + clientEP + ") gửi dữ liệu thành công");

                    string username = parts[0];
                    string password = parts[1];
                    string email = parts[2];
                    string fullname = parts[3];
                    string sdt = parts[4];

                    bool isUsernameExist = UsernameExist(username); //cái đoạn này logic hơi ngược tí =)))))
                    string response;
                    if (isUsernameExist)
                        response = "Register failed";
                    else
                    {
                        AddUsertoDatabase(username, password, email, fullname, sdt);
                        response = "Register success";
                    }

                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    stream.Write(responseBytes, 0, responseBytes.Length);

                    AppendText($"Trạng thái đăng ký của client ({clientEP}): {response}");
                    if (!UsernameExist(username))
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
    }
}
