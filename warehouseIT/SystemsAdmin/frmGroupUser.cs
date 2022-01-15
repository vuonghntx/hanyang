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
    public partial class frmGroupUser : XtraForm
    {
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        public frmGroupUser()
        {
            InitializeComponent();
        }
        LayerLogicData.lgUserGruop lgNhomQuyen = new LayerLogicData.lgUserGruop();
        LayerObjectData.objUserGroup objNhomQuyen = new LayerObjectData.objUserGroup();

     
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
            if (e.Button.Properties.Caption =="New")
            {
                SystemsAdmin.frmGroupUser_Action frm = new SystemsAdmin.frmGroupUser_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.hinthi = new frmGroupUser_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Edit")
            {
                if (IDNhomQuyen != null)
                {
                    SystemsAdmin.frmGroupUser_Action frm = new SystemsAdmin.frmGroupUser_Action();
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.NhanData(IDNhomQuyen, MaNhom, TenNhom);
                    frm.hinthi = new frmGroupUser_Action.HienThiThongTin(ShowData);
                    frm.ShowDialog();
                }
              
            }
            if (e.Button.Properties.Caption == "Delete")
            {
                if (IDNhomQuyen != null)
                {
                    if (XtraMessageBox.Show("Are you sure you want to delete data?", "Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        lgNhomQuyen.DeleteData(IDNhomQuyen, saveConfig.UserName);
                        ShowData();
                    }
                }
            }
            if (e.Button.Properties.Caption == "Refresh")
            {

                ShowData();
            }
        }
        void ShowData()
        {
            gridControl.DataSource = lgNhomQuyen.ShowListData();
            try
            {
                IDNhomQuyen = gridView.GetRowCellValue(gridView.FocusedRowHandle, colNhomQID).ToString();
                MaNhom = gridView.GetRowCellValue(gridView.FocusedRowHandle, colUserGr_Code).ToString();
                TenNhom = gridView.GetRowCellValue(gridView.FocusedRowHandle, colUserGr_Name).ToString();
            }
            catch
            {
                IDNhomQuyen = null;
            }

        }

        private void frmNhomHang_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        string IDNhomQuyen, MaNhom, TenNhom;

        private void windowsUIButtonPanel_Click(object sender, EventArgs e)
        {

        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IDNhomQuyen = gridView.GetRowCellValue(gridView.FocusedRowHandle, colNhomQID).ToString();
                MaNhom = gridView.GetRowCellValue(gridView.FocusedRowHandle, colUserGr_Code).ToString();
                TenNhom = gridView.GetRowCellValue(gridView.FocusedRowHandle, colUserGr_Name).ToString();
            }
            catch
            {
                IDNhomQuyen = null;
            }
          
        }
    }
}
