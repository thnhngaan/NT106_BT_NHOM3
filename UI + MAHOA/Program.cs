using NT1062._2;
using NT1062._2a;

namespace BAITAP_NT106
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