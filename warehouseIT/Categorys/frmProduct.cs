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
    public partial class frmProduct : XtraForm
    {
        public frmProduct()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        LayerLogicData.lgProduct lgHangHoa = new LayerLogicData.lgProduct();
        
        string useraction;
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
            if (e.Button.Properties.Caption =="New")
            {
                Category.frmProduct_Action frm = new frmProduct_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.hinthi = new frmProduct_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Edit")
            {
                Category.frmProduct_Action frm = new frmProduct_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.NhanData(IDHang,MaHang,TenHang,MoTa,HangSX,NuocSX,DonViTinh,DonGia,IDNhom);
                frm.hinthi = new frmProduct_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Delete")
            {               
                if (XtraMessageBox.Show("Are you sure you want to delete data?", "Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lgHangHoa.DeleteData(IDHang, useraction);
                    ShowData();
                }
            }
            if (e.Button.Properties.Caption == "Refresh")
            {
                ShowData();
            }
        }
        void ShowData()
        {
            gridControl.DataSource = lgHangHoa.ShowListData();
            try
            {
                IDNhom = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDNhomHang).ToString();
                MaHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_code).ToString();
                TenHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Name).ToString();
                MoTa = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Detail).ToString();
                HangSX = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Manufacturer).ToString();
                NuocSX = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Country).ToString();
                DonViTinh = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Unit).ToString();
                DonGia = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Price).ToString();
                IDHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDProductGr).ToString();
            }
            catch
            {
                IDHang = null;
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
        string IDHang, MaHang, TenHang, MoTa, HangSX, NuocSX, DonViTinh, DonGia, IDNhom;
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IDNhom = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDNhomHang).ToString();
                MaHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_code).ToString();
                TenHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Name).ToString();
                MoTa = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Detail).ToString();
                HangSX = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Manufacturer).ToString();
                NuocSX = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Country).ToString();
                DonViTinh = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Unit).ToString();
                DonGia= gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Price).ToString();
                IDHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDProductGr).ToString();
            }
            catch 
            {
                IDHang = null;
            }
        }
    }
}
