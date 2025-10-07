namespace NT106_2._2
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
            Welcome.Location = new Point(136, 108);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(344, 105);
            Welcome.TabIndex = 0;
            Welcome.Text = "Welcome to class";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(195, 176);
            label1.Name = "label1";
            label1.Size = new Size(256, 65);
            label1.TabIndex = 1;
            label1.Text = "NT106.Q12";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(232, 260);
            button1.Name = "button1";
            button1.Size = new Size(155, 49);
            button1.TabIndex = 2;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(648, 479);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Welcome);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Label Welcome;
        private Label label1;
        private Button button1;
    }
}