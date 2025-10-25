namespace Server
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tạo form chính
            Form main = new Form();
            main.WindowState = FormWindowState.Minimized; // thu nhỏ lại
            main.ShowInTaskbar = false; //không hiện ở thanh taskbar

            // Tạo hai form phụ
            TCPServer_login loginForm = new TCPServer_login();
            TCPServer_register registerForm = new TCPServer_register();

            // Hiển thị cả hai form
            loginForm.Show();
            registerForm.Show();

            // Chạy vòng lặp ứng dụng theo form chính (dù nó có thể ẩn)
            Application.Run(main);
        }
    }
}