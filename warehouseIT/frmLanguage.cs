using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouseIT
{
    public partial class frmLanguage : DevExpress.XtraEditors.XtraForm
    {
        public frmLanguage()
        {
            InitializeComponent();
        }
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (radioKorean.Checked == true)
            {               
                saveConfig.savelanguage("KO");                    
            }
            else if (radioEnglish.Checked == true)
            {
                saveConfig.savelanguage("EN");
            } else 
            {                 
                saveConfig.savelanguage("VN");               
            }
            Application.Exit();
        }
    }
}