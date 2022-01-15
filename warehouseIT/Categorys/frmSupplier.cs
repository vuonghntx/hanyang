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
    public partial class frmSupplier : XtraForm
    {
        public frmSupplier()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        LayerLogicData.lgSupplier lgSupplier = new LayerLogicData.lgSupplier();
        string useraction;
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
            if (e.Button.Properties.Caption =="New")
            {
                Category.frmSupplier_Action frm = new frmSupplier_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.hinthi = new frmSupplier_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Edit")
            {
                Category.frmSupplier_Action frm = new frmSupplier_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.NhanData(IDSupplier, Supplier_Code, Supplier_Name, Supplier_Address, Supplier_Phone, Supplier_Email);
                frm.hinthi = new frmSupplier_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Delete")
            {               
                if (XtraMessageBox.Show("Are you sure you want to delete data?", "Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lgSupplier.DeleteData(IDSupplier, useraction);
                    ShowData();
                }
            }
        }
        void ShowData()
        {
            gridControl.DataSource = lgSupplier.ShowListData();
            try
            {
                IDSupplier = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDSupplier).ToString();
                Supplier_Code = gridView.GetRowCellValue(gridView.FocusedRowHandle, colSupplier_Code).ToString();
                Supplier_Name = gridView.GetRowCellValue(gridView.FocusedRowHandle, colSupplier_Name).ToString();
                Supplier_Address = gridView.GetRowCellValue(gridView.FocusedRowHandle, colSupplier_Address).ToString();
                Supplier_Email = gridView.GetRowCellValue(gridView.FocusedRowHandle, colSupplier_Email).ToString();
                Supplier_Phone = gridView.GetRowCellValue(gridView.FocusedRowHandle, colSupplier_phone).ToString();
            }
            catch
            {
                IDSupplier = null;
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
        string IDSupplier, Supplier_Code, Supplier_Name, Supplier_Address, Supplier_Phone, Supplier_Email;
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IDSupplier = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDSupplier).ToString();
                Supplier_Code = gridView.GetRowCellValue(gridView.FocusedRowHandle, colSupplier_Code).ToString();
                Supplier_Name = gridView.GetRowCellValue(gridView.FocusedRowHandle, colSupplier_Name).ToString();
                Supplier_Address = gridView.GetRowCellValue(gridView.FocusedRowHandle, colSupplier_Address).ToString();
                Supplier_Email = gridView.GetRowCellValue(gridView.FocusedRowHandle, colSupplier_Email).ToString();
                Supplier_Phone = gridView.GetRowCellValue(gridView.FocusedRowHandle, colSupplier_phone).ToString();
            }
            catch 
            {
                IDSupplier = null;
            }
        }
    }
}
