using System;
using System.Windows.Forms;
namespace DeLeon_SQLSelectInsertUpdate
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmClubRegistration());
        }
    }
}
