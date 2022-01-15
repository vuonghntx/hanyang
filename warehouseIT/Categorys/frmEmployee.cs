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
    public partial class frmEmployee : XtraForm
    {
        public frmEmployee()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        LayerLogicData.lgEmployee lgEmployee = new LayerLogicData.lgEmployee();
        string useraction;
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
            if (e.Button.Properties.Caption =="New")
            {
                Category.frmEmployee_Action frm = new frmEmployee_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.hinthi = new frmEmployee_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Edit")
            {
                Category.frmEmployee_Action frm = new frmEmployee_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.NhanData(IDEmployee,Employee_Code, Employee_Name, IDDepartment);
                frm.hinthi = new frmEmployee_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Delete")
            {               
                if (XtraMessageBox.Show("Are you sure you want to delete data?", "Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lgEmployee.DeleteData(IDDepartment, useraction);
                    ShowData();
                }
            }
        }
        void ShowData()
        {
            gridControl.DataSource = lgEmployee.ShowListData();
            try
            {
                IDEmployee = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDDepartment).ToString();
                Employee_Code = gridView.GetRowCellValue(gridView.FocusedRowHandle, colEmployee_Code).ToString();
                Employee_Name = gridView.GetRowCellValue(gridView.FocusedRowHandle, colEmployee_Name).ToString();
                IDDepartment = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDDepartment).ToString();
            }
            catch
            {
                IDEmployee = null;
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
        string IDEmployee, Employee_Code, Employee_Name, IDDepartment;

        private void gridControl_Click(object sender, EventArgs e)
        {

        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IDEmployee = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDDepartment).ToString();
                Employee_Code = gridView.GetRowCellValue(gridView.FocusedRowHandle, colEmployee_Code).ToString();
                Employee_Name = gridView.GetRowCellValue(gridView.FocusedRowHandle, colEmployee_Name).ToString();
                IDDepartment = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDDepartment).ToString();
            }
            catch 
            {
                IDEmployee = null;
            }
        }
    }
}
