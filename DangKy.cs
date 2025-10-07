using NT106_2._2;
using NT1062._2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace NT1062._2a
{
    public partial class DangKy: Form
    {
        public DangKy()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public bool CheckAccount(string account)
        {
            string pattern = @"^[a-zA-Z0-9]{6,20}$";
            return Regex.IsMatch(account, pattern);
        }

        public bool CheckEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com(\.vn)?$";
            return Regex.IsMatch(email, pattern);
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            string tenTK= textBox2.Text;
            string matKhau = textBox5.Text;
            string nhapLaiMK = textBox6.Text;
            string email = textBox3.Text;
            string fullname = textBox1.Text;
            string SDT = textBox4.Text;

            if (fullname=="")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản: ");
                return;
            }
            if (!CheckAccount(tenTK))
            {
                MessageBox.Show("Tên tài khoản không hợp lệ. Vui lòng nhập lại (6-20 ký tự, chỉ gồm chữ cái và số).");
                return;
            }
            if (!CheckEmail(email))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại.");
                return;
            }
            if (fullname == "")
            {
                MessageBox.Show("Vui lòng nhập SĐT: ");
            }
            if (matKhau.Length < 6 || matKhau.Length > 20)
            {
                MessageBox.Show("Mật khẩu phải từ 6 đến 20 ký tự.");
                return;
            }
            if (matKhau != nhapLaiMK)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp.");
                return;
            }

            Modify modify = new Modify();
            string hashedPassword = hashpassword.ToSHA256(matKhau);
            if (modify.Accounts("Select * from USERS where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng nhập email khác!");
            }
            else
            {
                try
                {
                    string query = $"INSERT INTO USERS (USERNAME, PASSWORD, EMAIL, MOBILENUMBER, FULLNAME) " +
                                           $"VALUES ('{tenTK}', '{hashedPassword}', '{email}', '{SDT}', '{fullname}')";
                    modify.Command(query);
                    MessageBox.Show("Đăng ký thành công!");
                    this.Hide();
                    new DangNhap().ShowDialog();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tên tài khoản khác!");
                }
            }
        }
    }
}
