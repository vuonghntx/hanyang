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
    public partial class frmInventoryDepartment : DevExpress.XtraEditors.XtraForm
    {
        public frmInventoryDepartment()
        {
            InitializeComponent();
        }
        LayerLogicData.lgProductInventory lg = new LayerLogicData.lgProductInventory();
        private void btnFind_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = lg.Show_InventoryAll(txtBeginDate.Text, txtEndDate.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}