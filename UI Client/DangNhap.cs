using Client;
using Client02;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client01
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();

            // Ẩn mật khẩu mặc định
            ps.UseSystemPasswordChar = true;

            // Gắn sự kiện
            pseye.Click += pseye_Click;
            Button_TaoTK.Click += Button_DangKy_Click;
            Button_DangNhap.Click += Button_DangNhap_Click;
        }

        // Nút Đăng nhập
        private async void Button_DangNhap_Click(object sender, EventArgs e)
        {
            string usernameValue = username.Text.Trim();
            string passwordValue = ps.Text.Trim();

            if (string.IsNullOrEmpty(usernameValue) || string.IsNullOrEmpty(passwordValue))
            {
                MessageBox.Show("⚠️ Vui lòng nhập tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash mật khẩu trước khi gửi
            string hashedPassword = hashpassword.ToSHA256(passwordValue);

            try
            {
                string result = await SendLoginRequestAsync(usernameValue, hashedPassword);

                if (result.Equals("Login success", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("✅ Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Home(usernameValue).ShowDialog();
                    this.Close();
                }
                else if (result.Equals("Login failed", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("❌ Sai tài khoản hoặc mật khẩu.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result.StartsWith("Fail"))
                {
                    MessageBox.Show("⚠️ Dữ liệu gửi không hợp lệ (server báo lỗi).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Phản hồi lạ từ server: {result}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SocketException)
            {
                MessageBox.Show("🚫 Không thể kết nối đến server.\nKiểm tra lại IP hoặc port (8080).", "Kết nối thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Gửi request đăng nhập qua TCP
        private async Task<string> SendLoginRequestAsync(string username, string hashedPassword)
        {
            const string serverIp = "192.168.156.1"; // IP server thật (giữ nguyên để khớp code của bên kia)
            const int serverPort = 8080; // Port login

            using (TcpClient client = new TcpClient())
            {
                await client.ConnectAsync(serverIp, serverPort);

                using (NetworkStream stream = client.GetStream())
                {
                    // Format dữ liệu đúng theo server: username|password
                    string request = $"{username}|{hashedPassword}";
                    byte[] data = Encoding.UTF8.GetBytes(request);
                    await stream.WriteAsync(data, 0, data.Length);

                    // Chờ phản hồi từ server
                    byte[] buffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

                    return response;
                }
            }
        }

        // Nút mở form Đăng ký
        private void Button_DangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DangKy().ShowDialog();
            this.Close();
        }

        // Nút ẩn/hiện mật khẩu
        private void pseye_Click(object sender, EventArgs e)
        {
            ps.UseSystemPasswordChar = !ps.UseSystemPasswordChar;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            // Có thể để trống
        }
    }
}
