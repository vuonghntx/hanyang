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
    public partial class frmListReceiptFind : DevExpress.XtraEditors.XtraForm
    {
        public frmListReceiptFind()
        {
            InitializeComponent();
        }
        LayerLogicData.lgNote_Receipt lgNote_Receipt = new LayerLogicData.lgNote_Receipt();
        LayerLogicData.lgNote_Detail lgNote_Detail = new LayerLogicData.lgNote_Detail();
        string ID, Code, DateAction, Detai, IDDepot, IDSupplier, Receiver, Delivery_Person;
        public delegate void SetDataFrom(string id, string code, string date, string iddepot, string idsupplier, string detail, string receiver, string delivery_person);
        public SetDataFrom setdataFrm;

        private void frmListReceiptFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ID != null)
                {
                    this.setdataFrm(ID, Code, DateAction, IDDepot, IDSupplier, Detai, Receiver, Delivery_Person);
                    this.Close();
                }
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

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            if (ID != null)
            {
                this.setdataFrm(ID, Code, DateAction,  IDDepot, IDSupplier, Detai, Receiver, Delivery_Person);
                this.Close();
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                ID = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collID).ToString();
                Code = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collCode).ToString();
                DateAction = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, colDateAction).ToString();
                Detai = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collDetail).ToString();
                IDDepot = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collIDDepot).ToString();
                IDSupplier = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collIDSupplier).ToString();
                Receiver = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, colReceiver).ToString();
                Delivery_Person = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, colDelivery_Person).ToString();
                ShowListDetailReceipt(ID);
            }
            catch
            {

            }
        }

        public void ShowListReceipt()
        {
            gridListReceipt.DataSource = lgNote_Receipt.ShowListData();
            try
            {
                ID = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collID).ToString();
                Code = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collCode).ToString();
                DateAction = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, colDateAction).ToString();
                Detai = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collDetail).ToString();
                IDDepot = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collIDDepot).ToString();
                IDSupplier = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collIDSupplier).ToString();
                Receiver = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, colReceiver).ToString();
                Delivery_Person = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, colDelivery_Person).ToString();
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
    }
}