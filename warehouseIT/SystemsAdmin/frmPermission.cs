using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouseIT.SystemsAdmin
{
    public partial class frmPermission : XtraForm
    {
        public frmPermission()
        {
            InitializeComponent();
        }
        LayerLogicData.lgGantPermission lgPermission = new LayerLogicData.lgGantPermission();

        
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
           
        }
        void ShowData()
        {
            gridDSChucNang.DataSource = lgPermission.ShowListPermisson();
        }

        private void frmNhomHang_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            //if (e.RowHandle >= 0)
            //    e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
     
       
    }
}
