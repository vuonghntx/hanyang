using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouseIT.ImportExport
{
    public partial class frmListReceipt : DevExpress.XtraEditors.XtraForm
    {
        public frmListReceipt()
        {
            InitializeComponent();
        }
        LayerLogicData.lgNote_Receipt lgNote_Receipt = new LayerLogicData.lgNote_Receipt();
        LayerLogicData.lgNote_Detail lgNote_Detail = new LayerLogicData.lgNote_Detail();
        string ID;
        public void ShowListReceipt()
        {
            gridListReceipt.DataSource = lgNote_Receipt.ShowListData();
            try
            {
                ID = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collID).ToString();
                ShowListDetailReceipt(ID);
            }
            catch 
            {

            }
        }
        public void ShowListDetailReceipt(string id)
        {
            gridHangHoa.DataSource = lgNote_Detail.Show_Receipt_New(id);
        }

        private void frmListReceipt_Load(object sender, EventArgs e)
        {
            ShowListReceipt();
        }

        private void mnWindows_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Refresh")
            {
                ShowListReceipt();
            }
            if (e.Button.Properties.Caption == "View")
            {
                //ShowListReceipt();
                // Show detail receipt 
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                ID = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collID).ToString();
                ShowListDetailReceipt(ID);
            }
            catch
            {

            }
        }
    }
}