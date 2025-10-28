using Client;
using Client01;
using System;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client02
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();

            // Ẩn mật khẩu mặc định
            ps.UseSystemPasswordChar = true;
            confirmps.UseSystemPasswordChar = true;

            // Kiểm tra null hình con mắt (tránh lỗi runtime)
            if (pseye != null) pseye.Click += pseye_Click;
            if (cfpseye != null) cfpseye.Click += pseye_Click;
        }

        // Kiểm tra họ tên
        bool CheckFullName(string name) =>
            Regex.IsMatch(name, @"^[A-Za-zÀ-ỹ]+(\s[A-Za-zÀ-ỹ]+)+$");

        // Kiểm tra username
        bool CheckUsername(string user) =>
            Regex.IsMatch(user, @"^[a-zA-Z0-9]{6,20}$");

        // Kiểm tra Gmail
        bool CheckEmail(string email) =>
            Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@gmail\.com(\.vn)?$");

        // Kiểm tra SĐT
        bool CheckPhone(string sdt) =>
            Regex.IsMatch(sdt, @"^0\d{9}$");

        // Kiểm tra mật khẩu mạnh
        bool CheckPasswordStrong(string pass) =>
            Regex.IsMatch(pass, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,32}$");

        // Nút Đăng ký
        private async void Button_DangKy_Click(object sender, EventArgs e)
        {
            string usernameValue = username.Text.Trim();
            string passwordValue = ps.Text.Trim();
            string confirmPass = confirmps.Text.Trim();
            string emailValue = email.Text.Trim();
            string fullNameValue = fullname.Text.Trim();
            string phone = sdt.Text.Trim();

            // Kiểm tra trống
            if (string.IsNullOrEmpty(fullNameValue) || string.IsNullOrEmpty(usernameValue) ||
                string.IsNullOrEmpty(emailValue) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(passwordValue) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin.", "Thiếu dữ liệu");
                return;
            }

            // Các kiểm tra chi tiết
            if (!CheckFullName(fullNameValue))
            {
                MessageBox.Show("Họ tên sai định dạng (phải có ít nhất 2 từ, không số/ký tự đặc biệt).");
                return;
            }
            if (!CheckUsername(usernameValue))
            {
                MessageBox.Show("Tên tài khoản 6–20 ký tự, không khoảng trắng, chỉ chữ và số.");
                return;
            }
            if (!CheckEmail(emailValue))
            {
                MessageBox.Show("Email phải là Gmail hợp lệ (example@gmail.com).");
                return;
            }
            if (!CheckPhone(phone))
            {
                MessageBox.Show("Số điện thoại phải có 10 số, bắt đầu bằng 0.");
                return;
            }
            if (!CheckPasswordStrong(passwordValue))
            {
                MessageBox.Show("Mật khẩu yếu. Cần 1 chữ hoa, 1 chữ thường, 1 số (6–32 ký tự).");
                return;
            }
            if (passwordValue != confirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }

            MessageBox.Show("Dữ liệu hợp lệ. Đang gửi yêu cầu...");

            string hashedPassword = hashpassword.ToSHA256(passwordValue);

            try
            {
                string result = await SendRegisterRequestAsync(usernameValue, hashedPassword, emailValue, fullNameValue, phone);

                if (result == "Register success")
                {
                    MessageBox.Show("Tạo tài khoản thành công.");
                    this.Hide();
                    new DangNhap().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại. Tài khoản có thể đã tồn tại.");
                }
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server.");
            }
        }

        // Gửi dữ liệu qua TCP
        private async Task<string> SendRegisterRequestAsync(string username, string hashedPassword, string email, string fullname, string sdt)
        {
            const string serverIp = "192.168.153.1";
            const int serverPort = 8081;

            using (TcpClient client = new TcpClient())
            {
                await client.ConnectAsync(serverIp, serverPort);
                using (NetworkStream stream = client.GetStream())
                {
                    string request = $"{username}|{hashedPassword}|{email}|{fullname}|{sdt}";
                    byte[] data = Encoding.UTF8.GetBytes(request);
                    await stream.WriteAsync(data, 0, data.Length);

                    byte[] buffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    return Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();
                }
            }
        }

        // Mở form đăng nhập
        private void Link_DangNhap_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new DangNhap().ShowDialog();
            this.Close();
        }

        // Con mắt mật khẩu
        private void pseye_Click(object sender, EventArgs e)
        {
            ps.UseSystemPasswordChar = !ps.UseSystemPasswordChar;
        }

        // Con mắt xác nhận mật khẩu
        private void cfpseye_Click(object sender, EventArgs e)
        {
            confirmps.UseSystemPasswordChar = !confirmps.UseSystemPasswordChar;
        }
    }
}
