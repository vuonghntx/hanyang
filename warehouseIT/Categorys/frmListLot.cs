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
    public partial class frmListLot : XtraForm
    {
        public frmListLot()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        LayerLogicData.lgListLot lgListLot = new LayerLogicData.lgListLot();
        string useraction;
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
            if (e.Button.Properties.Caption =="New")
            {
                Category.frmListLot_Action frm = new frmListLot_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.NhanData(null, IDProduct, null, null, null); ;
                frm.hinthi = new frmListLot_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Edit")
            {
                Category.frmListLot_Action frm = new frmListLot_Action();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.NhanData(IDListLot, IDProduct, DateProduction, Serial, Detail);;
                frm.hinthi = new frmListLot_Action.HienThiThongTin(ShowData);
                frm.ShowDialog();
            }
            if (e.Button.Properties.Caption == "Delete")
            {               
                if (XtraMessageBox.Show("Are you sure you want to delete data?", "Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lgListLot.DeleteData(IDListLot, useraction);
                    ShowData(IDProduct);
                }
            }
        }
        LayerLogicData.lgProduct lgHangHoa = new LayerLogicData.lgProduct();
        void ShowDataProduct()
        {
            gridControl1.DataSource = lgHangHoa.ShowListData();
            try
            {
                IDProduct = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDProduct).ToString();
                ShowData(IDProduct);

            }
            catch
            {
                IDProduct = null;
            }

        }
        void ShowData(string idproduct)
        {
            gridControl.DataSource = lgListLot.ShowListData(idproduct);
            try
            {
                IDListLot = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDLot).ToString();
                Serial = gridView.GetRowCellValue(gridView.FocusedRowHandle, colSerial).ToString();
                DateProduction = gridView.GetRowCellValue(gridView.FocusedRowHandle, colDateProduction).ToString();
            }
            catch
            {
                IDListLot = null;
            }
        }

        private void frmNhomHang_Load(object sender, EventArgs e)
        {
            ShowDataProduct();
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        string IDListLot, IDProduct, Serial, DateProduction, Detail;

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IDProduct = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDProduct).ToString();
                ShowData(IDProduct);
               
            }
            catch
            {
                IDProduct = null;
            }
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IDListLot = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDLot).ToString();
                Serial = gridView.GetRowCellValue(gridView.FocusedRowHandle, colSerial).ToString();
                DateProduction = gridView.GetRowCellValue(gridView.FocusedRowHandle, colDateProduction).ToString();
            }
            catch 
            {
                IDListLot = null;
            }
        }
    }
}
