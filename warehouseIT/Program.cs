using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace warehouseIT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            saveConfigRegedit saveConfig = new saveConfigRegedit();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (saveConfig.language == null)
            {
                Application.Run(new frmLanguage());

            }else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(saveConfig.language);
                Application.Run(new frmMain());
            }
           
        }
    }
}
