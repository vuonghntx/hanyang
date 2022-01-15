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
    public partial class frmDepot : XtraForm
    {
        public frmDepot()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        LayerLogicData.lgDepot lgDepot = new LayerLogicData.lgDepot();
        string useraction;
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
            if (e.Button.Properties.Caption =="New")
            {
                Category.frmDepot_Action frm = new frmDepot_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.hinthi = new frmDepot_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Edit")
            {
                Category.frmDepot_Action frm = new frmDepot_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.NhanData(IDDepot, Depot_Code, Depot_Name);
                frm.hinthi = new frmDepot_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Delete")
            {               
                if (XtraMessageBox.Show("Are you sure you want to delete data?", "Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lgDepot.DeleteData(IDDepot, useraction);
                    ShowData();
                }
            }
        }
        void ShowData()
        {
            gridControl.DataSource = lgDepot.ShowListData();
            try
            {
                IDDepot = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDDepot).ToString();
                Depot_Code = gridView.GetRowCellValue(gridView.FocusedRowHandle, colDepot_Code).ToString();
                Depot_Name = gridView.GetRowCellValue(gridView.FocusedRowHandle, colDepot_Name).ToString();
            }
            catch
            {
                IDDepot = null;
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
        string IDDepot, Depot_Code, Depot_Name;
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IDDepot = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDDepot).ToString();
                Depot_Code = gridView.GetRowCellValue(gridView.FocusedRowHandle, colDepot_Code).ToString();
                Depot_Name = gridView.GetRowCellValue(gridView.FocusedRowHandle, colDepot_Name).ToString();
            }
            catch 
            {
                IDDepot = null;
            }
        }
    }
}
