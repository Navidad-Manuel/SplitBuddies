using System;
using System.Windows.Forms;

namespace SplitBuddies.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDashboard()); // Esto ahora funcionará
        }
    }
}
