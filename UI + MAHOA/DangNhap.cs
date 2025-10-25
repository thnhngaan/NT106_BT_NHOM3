using BAITAP_NT106;
using NT1062._2a;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NT1062._2
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            string tentk = username.Text;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Vui lòng xác nhận bạn không phải người máy!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private Form currentFormChild;

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text.Trim();
            string password = ps.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }

            Modify modify = new Modify();
            string hashedPassword = hashpassword.ToSHA256(password);

            string query = $"SELECT * FROM USERS WHERE USERNAME = '{username}' AND PASSWORD = '{hashedPassword}'";
            if (modify.Accounts(query).Count != 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                OpenChildForm(new Home());
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!");
            }
        }
        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DangKy());
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();

            currentFormChild = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private bool _showPwd = false;
        private void button1_Click_1(object sender, EventArgs e)
        {
            _showPwd = !_showPwd;
            ps.UseSystemPasswordChar = !_showPwd;
            pseye.Image = _showPwd ? BAITAP_NT106.Properties.Resources.eye_open :
                BAITAP_NT106.Properties.Resources.eye_close;
        }
    }
}
