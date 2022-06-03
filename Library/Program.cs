using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSelectApp());
            switch (FrmSelectApp.Mode)
            {
                case 0:
                    Application.Exit();
                    break;
                case 1:
                    Application.Run(new FrmMemberLogin());
                    if (FrmMemberLogin.LogedIn) Application.Run(new FrmMemberMain());
                    break;
                case 2:
                    Application.Run(new FrmMain());
                    break;
            }
        }
    }
}
