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
    public partial class frmUser : XtraForm
    {
        public frmUser()
        {
            InitializeComponent();
        }
        LayerLogicData.lgUser LgDMUser = new LayerLogicData.lgUser();

        ClassReference.EncodeMD5 encode = new ClassReference.EncodeMD5();
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
            if (e.Button.Properties.Caption =="New")
            {
                SystemsAdmin.frmUser_Action frm = new SystemsAdmin.frmUser_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.hinthi = new SystemsAdmin.frmUser_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Lock")
            {
                LgDMUser.IsLock(IDUser, "True");
                ShowData();
            }
            if (e.Button.Properties.Caption == "Reset Password")
            {
                if (XtraMessageBox.Show("Do you want to reset your password?","Notification!", MessageBoxButtons.OKCancel)== DialogResult.OK)
                {
                    LgDMUser.ResetMatKhau(encode.EncodeString("1234@1234a"), IDUser);
                    XtraMessageBox.Show("Default password 1234@1234a");
                }                
            }
        }
        void ShowData()
        {
            gridControl.DataSource = LgDMUser.ShowListData();
            try
            {
                IDUser = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDUser).ToString();
                UserName = gridView.GetRowCellValue(gridView.FocusedRowHandle, colTenDangNhap).ToString();
                FullName = gridView.GetRowCellValue(gridView.FocusedRowHandle, colTenHienThi).ToString();
            }
            catch
            {
                IDUser = null;
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
        string IDUser, UserName, FullName;
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IDUser = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDUser).ToString();
                UserName = gridView.GetRowCellValue(gridView.FocusedRowHandle, colTenDangNhap).ToString();
                FullName = gridView.GetRowCellValue(gridView.FocusedRowHandle, colTenHienThi).ToString();
            }
            catch
            {
                IDUser = null;
            }

        }
    }
}
