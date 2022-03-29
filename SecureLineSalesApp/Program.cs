using SecureLineSalesApp.Components.Dashboard;
using SecureLineSalesApp.Components.SpalshScreen;
using System;
using System.Windows.Forms;

namespace SecureLineSalesApp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }
    }
}