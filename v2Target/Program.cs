using System;
using System.Windows.Forms;
using v2Framework.Uitls;

namespace v2Target
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SyncForm());
        }
    }
}