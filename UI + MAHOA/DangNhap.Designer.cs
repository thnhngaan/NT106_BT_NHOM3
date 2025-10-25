using System.Windows.Forms;

namespace NT1062._2
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
            checkBox1 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dnhap = new Button();
            TaoTK = new Button();
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
            label8.Location = new Point(279, 535);
            label8.Name = "label8";
            label8.Size = new Size(103, 16);
            label8.TabIndex = 44;
            label8.Text = "Quên mật khẩu?";
            label8.Click += label8_Click;
            // 
            // ps
            // 
            ps.Location = new Point(179, 312);
            ps.Margin = new Padding(3, 2, 3, 2);
            ps.Name = "ps";
            ps.Size = new Size(225, 27);
            ps.TabIndex = 39;
            ps.UseSystemPasswordChar = true;
            ps.TextChanged += textBox2_TextChanged;
            // 
            // username
            // 
            username.Location = new Point(179, 239);
            username.Margin = new Padding(3, 2, 3, 2);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(225, 27);
            username.TabIndex = 38;
            username.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Arial", 8F, FontStyle.Bold);
            label2.Location = new Point(175, 286);
            label2.Name = "label2";
            label2.Size = new Size(79, 16);
            label2.TabIndex = 33;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Arial", 8F, FontStyle.Bold);
            label1.Location = new Point(175, 212);
            label1.Name = "label1";
            label1.Size = new Size(82, 16);
            label1.TabIndex = 32;
            label1.Text = "Username:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientActiveCaption;
            pictureBox1.Location = new Point(153, 63);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 580);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label3);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(179, 379);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 58);
            panel1.TabIndex = 48;
            panel1.Paint += panel1_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 20F);
            checkBox1.Location = new Point(13, 21);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 54;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 7.8F, FontStyle.Bold);
            label3.Location = new Point(33, 21);
            label3.Name = "label3";
            label3.Size = new Size(175, 16);
            label3.TabIndex = 0;
            label3.Text = "Tôi không phải người máy";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.BackColor = Color.SteelBlue;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(153, 63);
            label4.Name = "label4";
            label4.Size = new Size(352, 105);
            label4.TabIndex = 50;
            label4.Text = "ĐĂNG NHẬP";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(588, 1412);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 51;
            label5.Text = "label5";
            // 
            // dnhap
            // 
            dnhap.BackColor = Color.SteelBlue;
            dnhap.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            dnhap.ForeColor = Color.Black;
            dnhap.Location = new Point(179, 466);
            dnhap.Margin = new Padding(4, 5, 4, 5);
            dnhap.Name = "dnhap";
            dnhap.Size = new Size(113, 42);
            dnhap.TabIndex = 52;
            dnhap.Text = "Đăng nhập";
            dnhap.UseVisualStyleBackColor = false;
            dnhap.Click += button1_Click;
            // 
            // TaoTK
            // 
            TaoTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TaoTK.BackColor = Color.SteelBlue;
            TaoTK.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            TaoTK.ForeColor = Color.Black;
            TaoTK.Location = new Point(254, 562);
            TaoTK.Margin = new Padding(4, 5, 4, 5);
            TaoTK.Name = "TaoTK";
            TaoTK.Size = new Size(151, 42);
            TaoTK.TabIndex = 53;
            TaoTK.Text = "Tạo tài khoản";
            TaoTK.UseVisualStyleBackColor = false;
            TaoTK.Click += buttonDangKy_Click;
            // 
            // pseye
            // 
            pseye.BackColor = SystemColors.Window;
            pseye.FlatAppearance.BorderSize = 0;
            pseye.Image = BAITAP_NT106.Properties.Resources.eye_close;
            pseye.Location = new Point(380, 312);
            pseye.Name = "pseye";
            pseye.Size = new Size(24, 27);
            pseye.TabIndex = 54;
            pseye.TabStop = false;
            pseye.UseVisualStyleBackColor = false;
            pseye.Click += button1_Click_1;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = BAITAP_NT106.Properties.Resources.download;
            ClientSize = new Size(660, 706);
            Controls.Add(pseye);
            Controls.Add(TaoTK);
            Controls.Add(dnhap);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(ps);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button dnhap;
        private CheckBox checkBox1;
        private Button TaoTK;
        private Button pseye;
    }
}