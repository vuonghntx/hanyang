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

namespace warehouseIT.Category
{
    public partial class frmProductGr : XtraForm
    {
        public frmProductGr()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        LayerLogicData.lgProductGr lgnhom = new LayerLogicData.lgProductGr();
        string useraction;
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
            if (e.Button.Properties.Caption =="New")
            {
                Category.frmProductGr_Action frm = new frmProductGr_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.hinthi = new frmProductGr_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Edit")
            {
                Category.frmProductGr_Action frm = new frmProductGr_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.NhanData(IDNhomHang, MaNhom, TenNhom);
                frm.hinthi = new frmProductGr_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Delete")
            {
                //DanhMuc.frmNhomHang_Action frm = new frmNhomHang_Action();
                //frm.StartPosition = FormStartPosition.CenterScreen;
                //frm.hinthi = new frmNhomHang_Action.HienThiThongTin(ShowData);
                //frm.ShowDialog();
               
                if (XtraMessageBox.Show("Are you sure you want to delete data?", "Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lgnhom.DeleteData(IDNhomHang, useraction);
                    ShowData();
                }
            }
        }
        void ShowData()
        {
            gridControl.DataSource = lgnhom.ShowListData();
            try
            {
                IDNhomHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDProductGr).ToString();
                MaNhom = gridView.GetRowCellValue(gridView.FocusedRowHandle, colMaNhom).ToString();
                TenNhom = gridView.GetRowCellValue(gridView.FocusedRowHandle, colTenNhom).ToString();

            }
            catch //(Exception ex)
            {
                IDNhomHang = null;
                // XtraMessageBox.Show("Lỗi: " + ex.Message);
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
        string IDNhomHang, MaNhom, TenNhom;
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IDNhomHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDProductGr).ToString();
                MaNhom = gridView.GetRowCellValue(gridView.FocusedRowHandle, colMaNhom).ToString();
                TenNhom = gridView.GetRowCellValue(gridView.FocusedRowHandle, colTenNhom).ToString();
            }
            catch 
            {
                IDNhomHang = null;
            }
        }
    }
}
