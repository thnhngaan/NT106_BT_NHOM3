namespace Server
{
    partial class TCPServer_register
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
            label3 = new Label();
            rtb_servernotify = new RichTextBox();
            tb_ipserver = new TextBox();
            label2 = new Label();
            label1 = new Label();
            rtb_clientsconnection = new RichTextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(380, 31);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 11;
            label3.Text = "ĐĂNG KÝ";
            // 
            // rtb_servernotify
            // 
            rtb_servernotify.Location = new Point(57, 127);
            rtb_servernotify.Name = "rtb_servernotify";
            rtb_servernotify.ReadOnly = true;
            rtb_servernotify.Size = new Size(529, 420);
            rtb_servernotify.TabIndex = 10;
            rtb_servernotify.Text = "";
            // 
            // tb_ipserver
            // 
            tb_ipserver.Location = new Point(132, 77);
            tb_ipserver.Name = "tb_ipserver";
            tb_ipserver.ReadOnly = true;
            tb_ipserver.Size = new Size(191, 27);
            tb_ipserver.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 80);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "IP Server:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(606, 94);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 7;
            label1.Text = "Các Client đang kết nối:";
            // 
            // rtb_clientsconnection
            // 
            rtb_clientsconnection.Location = new Point(606, 117);
            rtb_clientsconnection.Name = "rtb_clientsconnection";
            rtb_clientsconnection.ReadOnly = true;
            rtb_clientsconnection.Size = new Size(248, 430);
            rtb_clientsconnection.TabIndex = 6;
            rtb_clientsconnection.Text = "";
            // 
            // TCPServer_register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 563);
            Controls.Add(label3);
            Controls.Add(rtb_servernotify);
            Controls.Add(tb_ipserver);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtb_clientsconnection);
            Name = "TCPServer_register";
            Text = "TCP/IP Server Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private RichTextBox rtb_servernotify;
        private TextBox tb_ipserver;
        private Label label2;
        private Label label1;
        private RichTextBox rtb_clientsconnection;
    }
}