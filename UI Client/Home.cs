using Client01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client
{
    public partial class Home : Form
    {


        private string currentUsername;

        public Home(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }


        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullname_textbox_TextChanged(object sender, EventArgs e)
        {

        }




        private void dangxuat_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DangNhap().ShowDialog();
            this.Close();
        }

        private async void thongtin_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(currentUsername))
                {
                    MessageBox.Show("Không có thông tin tài khoản. Vui lòng đăng xuất và đăng nhập lại.");
                    return;
                }

                string response = await SendInfoRequestAsync(currentUsername);

                string[] parts = response.Split('|'); //INFO|username|fullname|email|phonenumber"

                if (parts.Length == 5 && parts[0] == "INFO")
                {
                    string username = parts[1]; 
                    string fullname = parts[2];
                    string email = parts[3];
                    string phonenumber = parts[4];

                    TextBox_User.Text = username;
                    TextBox_Name.Text = fullname;
                    TextBox_Mail.Text = email;         
                    TexBox_SDT.Text = phonenumber;
                }
                else
                {
                    MessageBox.Show($"Phản hồi không hợp lệ từ server: {response}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến server: {ex.Message}");
            }
        }

        private async Task<string> SendInfoRequestAsync(string username)
        {
            const string serverIp = "192.168.156.1";  
            const int serverPort = 8080;              

            using (TcpClient client = new TcpClient())
            {
                await client.ConnectAsync(serverIp, serverPort);
                using (NetworkStream stream = client.GetStream())
                {
                
                    string request = $"INFO|{username}\n";  //INFO|username
                    byte[] data = Encoding.UTF8.GetBytes(request);
                    await stream.WriteAsync(data, 0, data.Length);
                    await stream.FlushAsync();

                    byte[] buffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

                    return response;
                }
            }
        }


        //private async Task<string> SendInfoRequestAsync(string username)
        //{
        //    const string serverIp = "192.168.156.1";
        //    const int serverPort = 8080;

        //    using (TcpClient client = new TcpClient())
        //    {
        //        await client.ConnectAsync(serverIp, serverPort);
        //        using (NetworkStream stream = client.GetStream())
        //        {
        //            string request = $"INFO|{username}\n";
        //            byte[] data = Encoding.UTF8.GetBytes(request);
        //            await stream.WriteAsync(data, 0, data.Length);
        //            await stream.FlushAsync();

        //            byte[] buffer = new byte[1024];
        //            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
        //            string response = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

        //            return response;
        //        }
        //    }
        //}


    }
}
