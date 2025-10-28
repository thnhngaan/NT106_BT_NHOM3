using System.Configuration;
using System.Windows.Forms;

namespace Client02
{
    partial class DangKy
    {
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
            pictureBox1 = new PictureBox();
            ps = new TextBox();
            sdt = new TextBox();
            email = new TextBox();
            username = new TextBox();
            fullname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            Button_Dangky = new Button();
            Link_DangNhap = new LinkLabel();
            label11 = new Label();
            confirmps = new TextBox();
            cfpseye = new Button();
            pseye = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientActiveCaption;
            pictureBox1.Location = new Point(144, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 716);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // ps
            // 
            ps.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ps.Location = new Point(207, 511);
            ps.Margin = new Padding(0);
            ps.Name = "ps";
            ps.Size = new Size(440, 27);
            ps.TabIndex = 23;
            ps.UseSystemPasswordChar = true;
            // 
            // sdt
            // 
            sdt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sdt.Location = new Point(207, 448);
            sdt.Name = "sdt";
            sdt.Size = new Size(449, 27);
            sdt.TabIndex = 22;
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.Location = new Point(207, 371);
            email.Name = "email";
            email.Size = new Size(449, 27);
            email.TabIndex = 21;
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.Location = new Point(207, 287);
            username.Name = "username";
            username.Size = new Size(449, 27);
            username.TabIndex = 20;
            // 
            // fullname
            // 
            fullname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullname.Location = new Point(207, 218);
            fullname.Name = "fullname";
            fullname.Size = new Size(449, 27);
            fullname.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientActiveCaption;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(207, 565);
            label6.Name = "label6";
            label6.Size = new Size(140, 18);
            label6.TabIndex = 18;
            label6.Text = "Confirm password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(207, 493);
            label5.Name = "label5";
            label5.Size = new Size(81, 18);
            label5.TabIndex = 17;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(207, 427);
            label4.Name = "label4";
            label4.Size = new Size(118, 18);
            label4.TabIndex = 16;
            label4.Text = "Mobile number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(207, 350);
            label3.Name = "label3";
            label3.Size = new Size(111, 18);
            label3.TabIndex = 15;
            label3.Text = "Email address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(204, 266);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 14;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 197);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 13;
            label1.Text = "Full name:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Right;
            label7.Location = new Point(847, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientActiveCaption;
            label8.Font = new Font("Arial", 8F);
            label8.Location = new Point(297, 737);
            label8.Name = "label8";
            label8.Size = new Size(141, 16);
            label8.TabIndex = 27;
            label8.Text = "Bạn đã có tài khoản?";
            // 
            // Button_Dangky
            // 
            Button_Dangky.BackColor = Color.SteelBlue;
            Button_Dangky.Font = new Font("Arial", 10F, FontStyle.Bold);
            Button_Dangky.Location = new Point(310, 660);
            Button_Dangky.Name = "Button_Dangky";
            Button_Dangky.Size = new Size(220, 62);
            Button_Dangky.TabIndex = 32;
            Button_Dangky.Text = "Đăng ký";
            Button_Dangky.UseVisualStyleBackColor = false;
            Button_Dangky.Click += Button_DangKy_Click;
            // 
            // Link_DangNhap
            // 
            Link_DangNhap.AutoSize = true;
            Link_DangNhap.BackColor = SystemColors.GradientActiveCaption;
            Link_DangNhap.Font = new Font("Arial", 8F);
            Link_DangNhap.LinkColor = SystemColors.Highlight;
            Link_DangNhap.Location = new Point(444, 737);
            Link_DangNhap.Name = "Link_DangNhap";
            Link_DangNhap.Size = new Size(107, 16);
            Link_DangNhap.TabIndex = 33;
            Link_DangNhap.TabStop = true;
            Link_DangNhap.Text = "Bấm đăng nhập";
            Link_DangNhap.LinkClicked += Link_DangNhap_Click;
            // 
            // label11
            // 
            label11.BackColor = Color.SteelBlue;
            label11.Font = new Font("Arial", 18F, FontStyle.Bold);
            label11.ImageAlign = ContentAlignment.BottomCenter;
            label11.Location = new Point(144, 63);
            label11.Name = "label11";
            label11.Size = new Size(584, 105);
            label11.TabIndex = 51;
            label11.Text = "TẠO TÀI KHOẢN";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confirmps
            // 
            confirmps.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmps.Location = new Point(207, 586);
            confirmps.Name = "confirmps";
            confirmps.Size = new Size(440, 27);
            confirmps.TabIndex = 52;
            confirmps.UseSystemPasswordChar = true;
            // 
            // cfpseye
            // 
            cfpseye.BackColor = SystemColors.Window;
            cfpseye.FlatAppearance.BorderSize = 0;
            cfpseye.Image = Client.Properties.Resources.eye_close;
            cfpseye.Location = new Point(632, 586);
            cfpseye.Name = "cfpseye";
            cfpseye.Size = new Size(24, 27);
            cfpseye.TabIndex = 55;
            cfpseye.TabStop = false;
            cfpseye.UseVisualStyleBackColor = false;
            // 
            // pseye
            // 
            pseye.BackColor = SystemColors.Window;
            pseye.FlatAppearance.BorderSize = 0;
            pseye.Image = Client.Properties.Resources.eye_close;
            pseye.Location = new Point(632, 511);
            pseye.Name = "pseye";
            pseye.Size = new Size(24, 27);
            pseye.TabIndex = 56;
            pseye.TabStop = false;
            pseye.UseVisualStyleBackColor = false;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Client.Properties.Resources.download;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(847, 832);
            Controls.Add(pseye);
            Controls.Add(cfpseye);
            Controls.Add(confirmps);
            Controls.Add(label11);
            Controls.Add(Link_DangNhap);
            Controls.Add(Button_Dangky);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(ps);
            Controls.Add(sdt);
            Controls.Add(email);
            Controls.Add(username);
            Controls.Add(fullname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "DangKy";
            Text = "Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ps;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Button cfpseye;
        private LinkLabel Link_DangNhap;
        private Button Button_Dangky;
        private Label label11;
        private TextBox confirmps;
        private Button pseye;
    }
}

