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
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientActiveCaption;
            pictureBox1.Location = new Point(117, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 622);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(143, 499);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(259, 25);
            textBox6.TabIndex = 24;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(143, 434);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(259, 25);
            textBox5.TabIndex = 23;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(143, 374);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(259, 25);
            textBox4.TabIndex = 22;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 313);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(259, 25);
            textBox3.TabIndex = 21;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 253);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 25);
            textBox2.TabIndex = 20;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 25);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientActiveCaption;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(140, 476);
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
            label5.Location = new Point(140, 413);
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
            label4.Location = new Point(140, 353);
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
            label3.Location = new Point(140, 292);
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
            label2.Location = new Point(140, 232);
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
            label1.Location = new Point(140, 173);
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
            label7.Location = new Point(575, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientActiveCaption;
            label8.Font = new Font("Arial Narrow", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(183, 598);
            label8.Name = "label8";
            label8.Size = new Size(137, 16);
            label8.TabIndex = 27;
            label8.Text = "Bạn đã có tài khoản chưa?";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientActiveCaption;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(230, 136);
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
            label10.Location = new Point(117, 34);
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
            button1.Location = new Point(218, 560);
            button1.Name = "button1";
            button1.Size = new Size(149, 35);
            button1.TabIndex = 32;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.GradientActiveCaption;
            linkLabel1.Font = new Font("Arial Narrow", 7.8F);
            linkLabel1.Location = new Point(316, 598);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(86, 16);
            linkLabel1.TabIndex = 33;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Bấm đăng nhập";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = NT106_2._2.Properties.Resources.download;
            ClientSize = new Size(575, 693);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

