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
    public partial class frmListReturnFind : DevExpress.XtraEditors.XtraForm
    {
        public frmListReturnFind()
        {
            InitializeComponent();
        }
        LayerLogicData.lgNote_ReceiptReturn lgNote_Receipt = new LayerLogicData.lgNote_ReceiptReturn();
        LayerLogicData.lgNote_Detail lgNote_Detail = new LayerLogicData.lgNote_Detail();
        string ID, Code, DateAction, Detai, IDDepot, IDDepartment;
        public delegate void SetDataFrom(string id, string code, string date, string iddepot, string idsupplier, string detail);
        public SetDataFrom setdataFrm;

        private void frmListReceiptFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ID != null)
                {
                    this.setdataFrm(ID, Code, DateAction, IDDepot, IDDepartment, Detai);
                    this.Close();
                }
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            if (ID != null)
            {
                this.setdataFrm(ID, Code, DateAction,  IDDepot, IDDepartment, Detai);
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
                IDDepartment = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collIDDepartment).ToString();
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
                IDDepartment = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, collIDDepartment).ToString();
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