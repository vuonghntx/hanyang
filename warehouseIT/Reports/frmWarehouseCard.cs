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

namespace warehouseIT
{
    public partial class frmWarehouseCard : DevExpress.XtraEditors.XtraForm
    {
        public frmWarehouseCard()
        {
            InitializeComponent();
        }
        LayerLogicData.lgProductInventory lg = new LayerLogicData.lgProductInventory();
        string idproduct, idlot;

        private void frmWarehouseCard_Load(object sender, EventArgs e)
        {

        }

        private void bandedGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                idproduct = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, collIDProduct).ToString();
                idlot = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, colIDLot).ToString();
            }
            catch
            {

            }
        }

        private void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Detail")
            {
                if (idproduct != null && txtBeginDate.Text != "" && txtEndDate.Text != "")
                {
                    frmWarehouseCardDetail frm = new frmWarehouseCardDetail();
                    frm.GetData(idproduct, idlot, txtBeginDate.Text, txtEndDate.Text);
                    frm.ShowDialog();
                }
              
            } 
                
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = lg.Show_InventoryAll(txtBeginDate.Text, txtEndDate.Text);
            try
            {
                idproduct = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, collIDProduct).ToString();
                idlot = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, colIDLot).ToString();
            }
            catch 
            {

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}