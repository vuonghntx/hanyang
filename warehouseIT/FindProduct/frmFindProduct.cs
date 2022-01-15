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
    public partial class frmFindProduct : XtraForm
    {
        public frmFindProduct()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        LayerLogicData.lgProduct lgHangHoa = new LayerLogicData.lgProduct();
        public delegate void SendInformattion(string productID, string productCode, string productName, string productDetail, string productManufacturer, string productCountry, string productUnit, string productPrice);
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
        void ShowData()
        {
            gridControl.DataSource = lgHangHoa.ShowListData();
            try
            {
                productID = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDProduct).ToString();
                productCode = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_code).ToString();
                productName = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Name).ToString();
                productDetail = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Detail).ToString();
                productManufacturer = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Manufacturer).ToString();
                productCountry = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Country).ToString();
                productUnit = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Unit).ToString();
                productPrice = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Price).ToString();
                productID = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDProductGr).ToString();
            }
            catch
            {
                productID = null;
            }

        }
        LayerLogicData.lgFindProduct lghh = new LayerLogicData.lgFindProduct();
        string productCode, productName, productDetail, productManufacturer, productCountry, productID, productUnit, productPrice;

        private void frmFindProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (productID != null)
                {
                    this.sender(productID, productCode, productName, productDetail, productManufacturer, productCountry, productUnit, productPrice);
                    this.Close();
                }

            }
        }
      
        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.sender(productID, productCode, productName, productDetail, productManufacturer, productCountry, productUnit, productPrice);
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
                productPrice = gridView.GetRowCellValue(gridView.FocusedRowHandle, colProduct_Price).ToString();
                productID = gridView.GetRowCellValue(gridView.FocusedRowHandle, colIDProductGr).ToString();
            }
            catch
            {
                productID = null;
            }
        }
    }
}
