namespace Client
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            dangxuat_button = new Button();
            fullname_label = new Label();
            TextBox_Name = new TextBox();
            TextBox_User = new TextBox();
            TextBox_Mail = new TextBox();
            TexBox_SDT = new TextBox();
            Button_ThongTin = new Button();
            email_label = new Label();
            phonenumber_label = new Label();
            username_label = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dangxuat_button
            // 
            dangxuat_button.BackColor = SystemColors.GradientActiveCaption;
            dangxuat_button.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dangxuat_button.ForeColor = SystemColors.HotTrack;
            dangxuat_button.Location = new Point(639, 214);
            dangxuat_button.Name = "dangxuat_button";
            dangxuat_button.Size = new Size(218, 81);
            dangxuat_button.TabIndex = 2;
            dangxuat_button.Text = "Đăng xuất";
            dangxuat_button.UseVisualStyleBackColor = false;
            dangxuat_button.Click += dangxuat_button_Click;
            // 
            // fullname_label
            // 
            fullname_label.AutoSize = true;
            fullname_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            fullname_label.Location = new Point(41, 56);
            fullname_label.Name = "fullname_label";
            fullname_label.Size = new Size(109, 28);
            fullname_label.TabIndex = 3;
            fullname_label.Text = "Full name:";
            // 
            // TextBox_Name
            // 
            TextBox_Name.Font = new Font("Segoe UI", 12F);
            TextBox_Name.Location = new Point(234, 56);
            TextBox_Name.Margin = new Padding(3, 4, 3, 4);
            TextBox_Name.Name = "TextBox_Name";
            TextBox_Name.ReadOnly = true;
            TextBox_Name.Size = new Size(343, 34);
            TextBox_Name.TabIndex = 4;
            TextBox_Name.TextChanged += fullname_textbox_TextChanged;
            // 
            // TextBox_User
            // 
            TextBox_User.Font = new Font("Segoe UI", 12F);
            TextBox_User.Location = new Point(234, 114);
            TextBox_User.Margin = new Padding(3, 4, 3, 4);
            TextBox_User.Name = "TextBox_User";
            TextBox_User.ReadOnly = true;
            TextBox_User.Size = new Size(343, 34);
            TextBox_User.TabIndex = 5;
            TextBox_User.TextChanged += username_textbox_TextChanged;
            // 
            // TextBox_Mail
            // 
            TextBox_Mail.Font = new Font("Segoe UI", 12F);
            TextBox_Mail.Location = new Point(234, 179);
            TextBox_Mail.Margin = new Padding(3, 4, 3, 4);
            TextBox_Mail.Name = "TextBox_Mail";
            TextBox_Mail.ReadOnly = true;
            TextBox_Mail.Size = new Size(343, 34);
            TextBox_Mail.TabIndex = 6;
            // 
            // TexBox_SDT
            // 
            TexBox_SDT.Font = new Font("Segoe UI", 12F);
            TexBox_SDT.Location = new Point(234, 250);
            TexBox_SDT.Margin = new Padding(3, 4, 3, 4);
            TexBox_SDT.Name = "TexBox_SDT";
            TexBox_SDT.ReadOnly = true;
            TexBox_SDT.Size = new Size(343, 34);
            TexBox_SDT.TabIndex = 7;
            // 
            // Button_ThongTin
            // 
            Button_ThongTin.BackColor = SystemColors.GradientActiveCaption;
            Button_ThongTin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_ThongTin.ForeColor = SystemColors.HotTrack;
            Button_ThongTin.Location = new Point(639, 56);
            Button_ThongTin.Name = "Button_ThongTin";
            Button_ThongTin.Size = new Size(218, 81);
            Button_ThongTin.TabIndex = 9;
            Button_ThongTin.Text = "Thông tin";
            Button_ThongTin.UseVisualStyleBackColor = false;
            Button_ThongTin.Click += thongtin_button_Click;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            email_label.Location = new Point(39, 179);
            email_label.Name = "email_label";
            email_label.Size = new Size(153, 28);
            email_label.TabIndex = 10;
            email_label.Text = "Email address: ";
            // 
            // phonenumber_label
            // 
            phonenumber_label.AutoSize = true;
            phonenumber_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            phonenumber_label.Location = new Point(39, 253);
            phonenumber_label.Name = "phonenumber_label";
            phonenumber_label.Size = new Size(161, 28);
            phonenumber_label.TabIndex = 11;
            phonenumber_label.Text = "Mobile address:";
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            username_label.ForeColor = SystemColors.ControlText;
            username_label.Location = new Point(39, 114);
            username_label.Name = "username_label";
            username_label.Size = new Size(111, 28);
            username_label.TabIndex = 12;
            username_label.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-145, -256);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1238, 608);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(922, 343);
            Controls.Add(username_label);
            Controls.Add(phonenumber_label);
            Controls.Add(email_label);
            Controls.Add(Button_ThongTin);
            Controls.Add(TexBox_SDT);
            Controls.Add(TextBox_Mail);
            Controls.Add(TextBox_User);
            Controls.Add(TextBox_Name);
            Controls.Add(fullname_label);
            Controls.Add(dangxuat_button);
            Controls.Add(pictureBox1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button dangxuat_button;
        private Label fullname_label;
        private TextBox TextBox_Name;
        private TextBox TextBox_User;
        private TextBox TextBox_Mail;
        private TextBox TexBox_SDT;
        private Button Button_ThongTin;
        private Label email_label;
        private Label phonenumber_label;
        private Label username_label;
        private PictureBox pictureBox1;
    }
}