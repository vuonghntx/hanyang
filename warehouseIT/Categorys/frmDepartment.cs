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
    public partial class frmDepartment : XtraForm
    {
        public frmDepartment()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        LayerLogicData.lgDepartment lgDepartment = new LayerLogicData.lgDepartment();
        string useraction;
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
            if (e.Button.Properties.Caption =="New")
            {
                Category.frmDepartment_Action frm = new frmDepartment_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.hinthi = new frmDepartment_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Edit")
            {
                Category.frmDepartment_Action frm = new frmDepartment_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.NhanData(IDDepartment,Department_Code, Department_Name);
                frm.hinthi = new frmDepartment_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Delete")
            {               
                if (XtraMessageBox.Show("Are you sure you want to delete data?", "Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lgDepartment.DeleteData(IDDepartment, useraction);
                    ShowData();
                }
            }
        }
        void ShowData()
        {
            gridControl.DataSource = lgDepartment.ShowListData();
            try
            {
                IDDepartment = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDDepartment).ToString();
                Department_Code = gridView.GetRowCellValue(gridView.FocusedRowHandle, colDepartment_Code).ToString();
                Department_Name = gridView.GetRowCellValue(gridView.FocusedRowHandle, colDepartment_Name).ToString();
            }
            catch
            {
                IDDepartment = null;
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
        string IDDepartment, Department_Code, Department_Name;
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IDDepartment = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDDepartment).ToString();
                Department_Code = gridView.GetRowCellValue(gridView.FocusedRowHandle, colDepartment_Code).ToString();
                Department_Name = gridView.GetRowCellValue(gridView.FocusedRowHandle, colDepartment_Name).ToString();
            }
            catch 
            {
                IDDepartment = null;
            }
        }
    }
}
