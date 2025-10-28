using System.Windows.Forms;

namespace Client01
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label8 = new Label();
            ps = new TextBox();
            username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            CheckBox = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Button_DangNhap = new Button();
            Button_TaoTK = new Button();
            pseye = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientActiveCaption;
            label8.Font = new Font("Arial", 7.8F);
            label8.Location = new Point(529, 351);
            label8.Name = "label8";
            label8.Size = new Size(103, 16);
            label8.TabIndex = 44;
            label8.Text = "Quên mật khẩu?";
            // 
            // ps
            // 
            ps.Location = new Point(192, 312);
            ps.Name = "ps";
            ps.Size = new Size(440, 27);
            ps.TabIndex = 39;
            ps.UseSystemPasswordChar = true;
            // 
            // username
            // 
            username.Location = new Point(192, 242);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(440, 27);
            username.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Arial", 8F, FontStyle.Bold);
            label2.Location = new Point(195, 283);
            label2.Name = "label2";
            label2.Size = new Size(79, 16);
            label2.TabIndex = 33;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Arial", 8F, FontStyle.Bold);
            label1.Location = new Point(192, 214);
            label1.Name = "label1";
            label1.Size = new Size(82, 16);
            label1.TabIndex = 32;
            label1.Text = "Username:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientActiveCaption;
            pictureBox1.Location = new Point(153, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 580);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(CheckBox);
            panel1.Controls.Add(label3);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(286, 392);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 59);
            panel1.TabIndex = 48;
            // 
            // CheckBox
            // 
            CheckBox.AutoSize = true;
            CheckBox.Font = new Font("Microsoft Sans Serif", 20F);
            CheckBox.Location = new Point(13, 21);
            CheckBox.Margin = new Padding(5);
            CheckBox.Name = "CheckBox";
            CheckBox.Size = new Size(18, 17);
            CheckBox.TabIndex = 54;
            CheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 7.8F, FontStyle.Bold);
            label3.Location = new Point(39, 22);
            label3.Name = "label3";
            label3.Size = new Size(175, 16);
            label3.TabIndex = 0;
            label3.Text = "Tôi không phải người máy";
            // 
            // label4
            // 
            label4.BackColor = Color.SteelBlue;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(153, 63);
            label4.Name = "label4";
            label4.Size = new Size(511, 105);
            label4.TabIndex = 50;
            label4.Text = "ĐĂNG NHẬP";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(587, 1412);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 51;
            label5.Text = "label5";
            // 
            // Button_DangNhap
            // 
            Button_DangNhap.BackColor = Color.SteelBlue;
            Button_DangNhap.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            Button_DangNhap.ForeColor = Color.Black;
            Button_DangNhap.Location = new Point(211, 504);
            Button_DangNhap.Margin = new Padding(5);
            Button_DangNhap.Name = "Button_DangNhap";
            Button_DangNhap.Size = new Size(193, 57);
            Button_DangNhap.TabIndex = 52;
            Button_DangNhap.Text = "Đăng nhập";
            Button_DangNhap.UseVisualStyleBackColor = false;
            Button_DangNhap.Click += Button_DangNhap_Click;
            // 
            // Button_TaoTK
            // 
            Button_TaoTK.BackColor = Color.SteelBlue;
            Button_TaoTK.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            Button_TaoTK.ForeColor = Color.Black;
            Button_TaoTK.Location = new Point(414, 504);
            Button_TaoTK.Margin = new Padding(5);
            Button_TaoTK.Name = "Button_TaoTK";
            Button_TaoTK.Size = new Size(193, 57);
            Button_TaoTK.TabIndex = 53;
            Button_TaoTK.Text = "Tạo tài khoản";
            Button_TaoTK.UseVisualStyleBackColor = false;
            Button_TaoTK.Click += Button_DangKy_Click;
            // 
            // pseye
            // 
            pseye.BackColor = SystemColors.Window;
            pseye.FlatAppearance.BorderSize = 0;
            pseye.Image = Client.Properties.Resources.eye_close;
            pseye.Location = new Point(608, 312);
            pseye.Name = "pseye";
            pseye.Size = new Size(24, 27);
            pseye.TabIndex = 54;
            pseye.TabStop = false;
            pseye.UseVisualStyleBackColor = false;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Client.Properties.Resources.download;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(848, 707);
            Controls.Add(pseye);
            Controls.Add(Button_TaoTK);
            Controls.Add(Button_DangNhap);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(ps);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "DangNhap";
            Text = "DangNhap";
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ps;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Label label4;
        private Label label5;
        private Button Button_DangNhap;
        private CheckBox CheckBox;
        private Button Button_TaoTK;
        private Button pseye;
    }
}