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

namespace warehouseIT.FindProduct
{
    public partial class frmFindProductInventory : XtraForm
    {
        public frmFindProductInventory()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        LayerLogicData.lgProductInventory lgInventory = new LayerLogicData.lgProductInventory();
        public delegate void SendInformattion(string productID, string productCode, string productName, string productDetail, string productManufacturer, string productCountry, string productUnit, string productPrice,string lotID, string lotNumber, string depotID, string depotName);
        public SendInformattion sender;
        string useraction;
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
           
            if (e.Button.Properties.Caption == "Refresh")
            {
                ShowData();
            }
        }
        string Date;
        public void GetData(string date)
        {
            Date = date;
        }
        void ShowData()
        {
            gridControl.DataSource = lgInventory.Show_ListInventoryExport(Date);
            try
            {
                productID = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDProduct).ToString();
                productCode = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_code).ToString();
                productName = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Name).ToString();
                productDetail = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Detail).ToString();
                productManufacturer = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Manufacturer).ToString();
                productCountry = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Country).ToString();
                productUnit = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Unit).ToString();
              //  productPrice = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Price).ToString();
               // productID = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDProductGr).ToString();
                lotID = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDLot).ToString();
                lotNumber = gridView.GetRowCellValue(gridView.FocusedRowHandle, colLot).ToString();
                depotID = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDDepot).ToString();
                depotName = gridView.GetRowCellValue(gridView.FocusedRowHandle, colDepotName).ToString();
            }
            catch
            {
                productID = null;
            }

        }
        LayerLogicData.lgFindProduct lghh = new LayerLogicData.lgFindProduct();
        string productCode, productName, productDetail, productManufacturer, productCountry, productID, productUnit, productPrice, lotID, lotNumber, depotID, depotName;

        private void frmFindProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (productID != null)
                {
                    this.sender(productID, productCode, productName, productDetail, productManufacturer, productCountry, productUnit, productPrice,lotID, lotNumber, depotID, depotName);
                    this.Close();
                }

            }
        }
      
        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.sender(productID, productCode, productName, productDetail, productManufacturer, productCountry, productUnit, productPrice, lotID, lotNumber, depotID, depotName);
                this.Close();
            }
            catch 
            {
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
       
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                productID = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDProduct).ToString();
                productCode = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_code).ToString();
                productName = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Name).ToString();
                productDetail = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Detail).ToString();
                productManufacturer = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Manufacturer).ToString();
                productCountry = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Country).ToString();
                productUnit = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Unit).ToString();
             //   productPrice = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Price).ToString();
                lotID = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDLot).ToString();
                lotNumber = gridView.GetRowCellValue(gridView.FocusedRowHandle, colLot).ToString();
                depotID = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDDepot).ToString();
                depotName = gridView.GetRowCellValue(gridView.FocusedRowHandle, colDepotName).ToString();
            }
            catch
            {
                productID = null;
            }
        }
    }
}
