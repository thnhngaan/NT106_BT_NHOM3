namespace BAITAP_NT106
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
            Welcome = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.BackColor = Color.Transparent;
            Welcome.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Welcome.ForeColor = Color.DeepSkyBlue;
            Welcome.Location = new Point(174, 190);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(379, 115);
            Welcome.TabIndex = 0;
            Welcome.Text = "Welcome to class";
            Welcome.Click += Welcome_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(218, 256);
            label1.Name = "label1";
            label1.Size = new Size(291, 75);
            label1.TabIndex = 1;
            label1.Text = "NT106.Q12";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(240, 334);
            button1.Name = "button1";
            button1.Size = new Size(190, 59);
            button1.TabIndex = 2;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(710, 467);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Welcome);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label Welcome;
        private Label label1;
        private Button button1;
    }
}