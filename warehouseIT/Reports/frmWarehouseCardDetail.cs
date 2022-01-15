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
    public partial class frmWarehouseCardDetail : DevExpress.XtraEditors.XtraForm
    {
        public frmWarehouseCardDetail()
        {
            InitializeComponent();
        }
        LayerLogicData.lgProductInventory lg = new LayerLogicData.lgProductInventory();
        string idproduct, idlot, datebegin, dateend;

        private void frmWarehouseCardDetail_Load(object sender, EventArgs e)
           
        {
            lg.Catulater_Inverntory(idproduct, idlot);
            gridControl1.DataSource = lg.Show_DetailWarehouseCard(datebegin, dateend, idproduct, idlot);
        }

        public void GetData(string IDproduct, string IDLot, string DateBegin, string DateEnd)
        {
            idproduct = IDproduct;
            idlot = IDLot;
            datebegin = DateBegin;
            dateend = DateEnd;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}