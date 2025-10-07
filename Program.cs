using NT1062._2;
using NT1062._2a;

namespace NT106_2._2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DangNhap()); 
        }
    }

}