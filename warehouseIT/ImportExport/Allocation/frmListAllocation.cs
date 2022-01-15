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
    public partial class frmListAllocation : DevExpress.XtraEditors.XtraForm
    {
        public frmListAllocation()
        {
            InitializeComponent();
        }
        LayerLogicData.lgNote_ExportAllocation lgNote_ExportAllocation = new LayerLogicData.lgNote_ExportAllocation();
        LayerLogicData.lgNote_Detail lgNote_Detail = new LayerLogicData.lgNote_Detail();
        string ID;
        public void ShowListAllocation()
        {
            gridListReceipt.DataSource = lgNote_ExportAllocation.ShowListData();
            try
            {
                ID = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collID).ToString();
                ShowListDetailAllocation(ID);
            }
            catch 
            {

            }
        }
        public void ShowListDetailAllocation(string id)
        {
            gridHangHoa.DataSource = lgNote_Detail.Show_ExportAllocation(id);
        }

        private void frmListReceipt_Load(object sender, EventArgs e)
        {
            ShowListAllocation();
        }

        private void mnWindows_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Refresh")
            {
                ShowListAllocation();
            }
            if (e.Button.Properties.Caption == "View")
            {
                //ShowListReceipt();                // Show detail receipt 
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                ID = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collID).ToString();
                ShowListDetailAllocation(ID);
            }
            catch
            {

            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}