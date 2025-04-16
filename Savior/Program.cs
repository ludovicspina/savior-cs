using System;
using System.Windows.Forms;
using MaintenanceToolGUI.UI;

namespace Savior
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}