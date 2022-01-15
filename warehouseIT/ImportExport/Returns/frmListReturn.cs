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
    public partial class frmListReturn : DevExpress.XtraEditors.XtraForm
    {
        public frmListReturn()
        {
            InitializeComponent();
        }
        LayerLogicData.lgNote_ReceiptReturn lgNote_Receipt = new LayerLogicData.lgNote_ReceiptReturn();
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
            gridHangHoa.DataSource = lgNote_Detail.Show_Receipt_Return(id);
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