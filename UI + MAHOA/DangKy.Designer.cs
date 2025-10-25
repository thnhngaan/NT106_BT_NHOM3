using System.Configuration;
using System.Windows.Forms;

namespace NT1062._2a
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
            confirmps = new TextBox();
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
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            pseye = new Button();
            cfps = new Panel();
            cfpseye = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cfps.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientActiveCaption;
            pictureBox1.Location = new Point(210, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 622);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // confirmps
            // 
            confirmps.Dock = DockStyle.Fill;
            confirmps.Location = new Point(0, 0);
            confirmps.Name = "confirmps";
            confirmps.Size = new Size(226, 25);
            confirmps.TabIndex = 24;
            confirmps.UseSystemPasswordChar = true;
            confirmps.TextChanged += textBox6_TextChanged;
            // 
            // ps
            // 
            ps.Location = new Point(235, 419);
            ps.Margin = new Padding(0);
            ps.Name = "ps";
            ps.Size = new Size(224, 25);
            ps.TabIndex = 23;
            ps.UseSystemPasswordChar = true;
            ps.TextChanged += textBox5_TextChanged;
            // 
            // sdt
            // 
            sdt.Location = new Point(235, 352);
            sdt.Name = "sdt";
            sdt.Size = new Size(224, 25);
            sdt.TabIndex = 22;
            sdt.TextChanged += textBox4_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(235, 291);
            email.Name = "email";
            email.Size = new Size(224, 25);
            email.TabIndex = 21;
            email.TextChanged += textBox3_TextChanged_1;
            // 
            // username
            // 
            username.Location = new Point(235, 231);
            username.Name = "username";
            username.Size = new Size(224, 25);
            username.TabIndex = 20;
            username.TextChanged += textBox2_TextChanged;
            // 
            // fullname
            // 
            fullname.Location = new Point(235, 172);
            fullname.Name = "fullname";
            fullname.Size = new Size(224, 25);
            fullname.TabIndex = 19;
            fullname.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientActiveCaption;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(232, 454);
            label6.Name = "label6";
            label6.Size = new Size(140, 18);
            label6.TabIndex = 18;
            label6.Text = "Confirm password:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(232, 391);
            label5.Name = "label5";
            label5.Size = new Size(81, 18);
            label5.TabIndex = 17;
            label5.Text = "Password:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(232, 331);
            label4.Name = "label4";
            label4.Size = new Size(118, 18);
            label4.TabIndex = 16;
            label4.Text = "Mobile number:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(232, 270);
            label3.Name = "label3";
            label3.Size = new Size(111, 18);
            label3.TabIndex = 15;
            label3.Text = "Email address:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(232, 210);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 14;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 151);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 13;
            label1.Text = "Full name:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Right;
            label7.Location = new Point(729, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientActiveCaption;
            label8.Font = new Font("Arial", 8F);
            label8.Location = new Point(263, 576);
            label8.Name = "label8";
            label8.Size = new Size(141, 16);
            label8.TabIndex = 27;
            label8.Text = "Bạn đã có tài khoản?";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientActiveCaption;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(321, 118);
            label9.Name = "label9";
            label9.Size = new Size(126, 21);
            label9.TabIndex = 28;
            label9.Text = "Tạo tài khoản";
            label9.TextAlign = ContentAlignment.BottomLeft;
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.SteelBlue;
            label10.Font = new Font("Arial", 18F, FontStyle.Bold);
            label10.Location = new Point(209, 12);
            label10.Name = "label10";
            label10.Size = new Size(352, 88);
            label10.TabIndex = 31;
            label10.Text = "ĐĂNG KÝ";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += label10_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Arial", 10F, FontStyle.Bold);
            button1.Location = new Point(312, 533);
            button1.Name = "button1";
            button1.Size = new Size(149, 36);
            button1.TabIndex = 32;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.GradientActiveCaption;
            linkLabel1.Font = new Font("Arial", 8F);
            linkLabel1.LinkColor = SystemColors.Highlight;
            linkLabel1.Location = new Point(401, 576);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 16);
            linkLabel1.TabIndex = 33;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Bấm đăng nhập";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pseye
            // 
            pseye.BackColor = SystemColors.Window;
            pseye.FlatAppearance.BorderSize = 0;
            pseye.FlatStyle = FlatStyle.Flat;
            pseye.Image = BAITAP_NT106.Properties.Resources.eye_close;
            pseye.Location = new Point(437, 419);
            pseye.Name = "pseye";
            pseye.Size = new Size(24, 24);
            pseye.TabIndex = 34;
            pseye.TabStop = false;
            pseye.UseVisualStyleBackColor = false;
            pseye.Click += pseye_Click;
            // 
            // cfps
            // 
            cfps.Controls.Add(cfpseye);
            cfps.Controls.Add(confirmps);
            cfps.Location = new Point(235, 477);
            cfps.Name = "cfps";
            cfps.Size = new Size(226, 24);
            cfps.TabIndex = 35;
            // 
            // cfpseye
            // 
            cfpseye.BackColor = SystemColors.Window;
            cfpseye.Dock = DockStyle.Right;
            cfpseye.FlatAppearance.BorderSize = 0;
            cfpseye.FlatStyle = FlatStyle.Flat;
            cfpseye.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cfpseye.Image = BAITAP_NT106.Properties.Resources.eye_close;
            cfpseye.Location = new Point(202, 0);
            cfpseye.Name = "cfpseye";
            cfpseye.Size = new Size(24, 24);
            cfpseye.TabIndex = 25;
            cfpseye.TabStop = false;
            cfpseye.UseVisualStyleBackColor = false;
            cfpseye.Click += cfpseye_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = BAITAP_NT106.Properties.Resources.download;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(729, 691);
            Controls.Add(cfps);
            Controls.Add(pseye);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
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
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cfps.ResumeLayout(false);
            cfps.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox confirmps;
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
        private System.Windows.Forms.Label label9;
        private Label label10;
        private Button button1;
        private LinkLabel linkLabel1;
        private Button pseye;
        private Panel cfps;
        private Button cfpseye;
    }
}

