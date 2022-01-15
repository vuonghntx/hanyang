using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouseIT.ImportExport
{
    public partial class frmImportReturn : DevExpress.XtraEditors.XtraForm
    {
        string UserName;
        public frmImportReturn()
        {
            InitializeComponent();
            UserName = saveConfig.UserName;
        }
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        LayerLogicData.lgNote_ReceiptReturn lgReceiptReturn = new LayerLogicData.lgNote_ReceiptReturn();
        LayerObjectData.objNote_ReceiptReturn objReceiptReturn = new LayerObjectData.objNote_ReceiptReturn();
        LayerLogicData.lgNote_UpdateData lgNote_UpdateData = new LayerLogicData.lgNote_UpdateData();
        LayerLogicData.lgNote_Detail lgNote_Detail = new LayerLogicData.lgNote_Detail();

        string ID;
        public void SetDataArray(string[] productCode, string[] productName, string[] productDetail, string[] productManufacturer, string[] productCountry, string[] productUnit, string[] productID, string[] productPrice)

        {
            for (int i = 0; i < 100; i++)
            {
                if (productID[i] != "" && productCode[i] != null)
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Code, productCode[i]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Name, productName[i]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Detail, productDetail[i]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Manufaceturer, productManufacturer[i]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Country, productCountry[i]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Unit, productUnit[i]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colIDProduct, productID[i]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colPrice, productPrice[i]);
                    if (ID != null)
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colID, ID);
                    else
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colID, -1);
                    gridView1.AddNewRow();
                }
            }
        }
        LayerLogicData.lgDepartment lgDepartment = new LayerLogicData.lgDepartment();
        public void ShowListDepartment()
        {
            gridDepartment.Properties.DataSource = lgDepartment.ShowListData();
            gridDepartment.EditValue = gridDepartment.Properties.GetKeyValue(0);
        }
        LayerLogicData.lgDepot lgDepot = new LayerLogicData.lgDepot();
        public void ShowListDepot()
        {
            gridDepot.Properties.DataSource = lgDepot.ShowListData();
            gridDepot.EditValue = gridDepot.Properties.GetKeyValue(0);
        }
        //, , , , , , , 
        public void SetData(string productID1, string productCode1, string productName1, string productDetail1, string productManufacturer1, string productCountry1, string productUnit1, string productPrice1, string lotID, string lotNumber, string depotID, string depotname)
        {
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Code, productCode1);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Name, productName1);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Detail, productDetail1);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Manufaceturer, productManufacturer1);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Country, productCountry1);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Unit, productUnit1);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colIDProduct, productID1);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colPrice, productPrice1);
         
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colIDLot, lotID);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colLotNumber, lotNumber);
            
            if (ID != null)
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colID, ID);
            else
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colID, -1);
        }
        LayerLogicData.lgFindProduct lgList = new LayerLogicData.lgFindProduct();
        public void ShowInformationProduct(string data)
        {
            if (txtDateAction.Text != "" && IDDepartment != null)
            {
                DataTable dt = lgList.ShowListProductImportDepartment(txtDateAction.Text, IDDepartment);

                if (dt.Rows.Count == 1)
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Code, dt.Rows[0]["Product_Code"].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Name, dt.Rows[0]["Product_Name"].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Detail, dt.Rows[0]["Product_Detail"].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Manufaceturer, dt.Rows[0]["Product_Manufacturer"].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Country, dt.Rows[0]["Product_Country"].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colProduct_Unit, dt.Rows[0]["Product_Unit"].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colIDProduct, dt.Rows[0]["IDProduct"].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colPrice, dt.Rows[0]["Product_Price"].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colIDLot, dt.Rows[0]["IDLot"].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colLotNumber, dt.Rows[0]["LotNumber"].ToString());
                    if (ID != null)
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colID, ID);
                    else
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colID, -1);
                }
                else
                {
                    FindProduct.frmFindProductInventory frm = new FindProduct.frmFindProductInventory();
                    frm.GetData(txtDateAction.Text);
                    frm.sender = new FindProduct.frmFindProductInventory.SendInformattion(SetData);
                    frm.ShowDialog();
                }
            }
            else
            {
                XtraMessageBox.Show("Please select a department", "Notification!");
            }
        }
        public void DeleteRowsEmpty()
        {
            gridView1.FocusedRowHandle = -1;
            string hangid;
            int k = 0;
            int sodong = gridView1.RowCount;
            while (k < sodong)
            {
                hangid = gridView1.GetRowCellValue(k, colIDProduct).ToString();
                if (hangid == null || hangid == "")
                {
                    gridView1.DeleteRow(k);
                    sodong = gridView1.RowCount;
                }
                else k++;
            }
        }
        public bool CheckQuantity()
        {
            bool kt = true;
            gridView1.FocusedRowHandle = -1;
            string quantity;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                quantity = gridView1.GetRowCellValue(i, colQuantity).ToString();

                if (quantity == null || quantity == "0")
                {
                    XtraMessageBox.Show("Please enter the input number", "Notification!");
                    gridView1.FocusedRowHandle = i;
                    gridView1.FocusedColumn = gridView1.VisibleColumns[8];
                    kt = false;
                    break;
                }
            }
            return kt;
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == colQuantity)
            {
                try
                {
                    string a = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colProduct_Code).ToString();
                    string idhang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colProduct_Code).ToString();
                    if ((idhang == null || idhang == "" || a == "" || a == null))
                        ShowInformationProduct(a);
                }
                catch { }
            }
            //if (e.Column == colLotNumber)
            //{
            //    try
            //    {
            //        string idproduct = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDProduct).ToString();
            //        string IDlot = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDLot).ToString();
            //        string lotnumber = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colLotNumber).ToString();
            //        if ((IDlot == null || lotnumber == "" || IDlot == "" || lotnumber == null) && idproduct !=null)
            //        {
            //            Category.frmListLotReceipt frm = new Category.frmListLotReceipt();
            //            frm.NhanData(idproduct);
            //            frm.SenderIFNumber = new Category.frmListLotReceipt.SenderInformationLotnumber(AccepLotnumber);
            //            frm.ShowDialog();
            //        }   
            //    }
            //    catch { }
            //}
        }
        public void AccepLotnumber(string IDlot, string LotNumber)
        {
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colIDLot, IDlot);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colLotNumber, LotNumber);

        }
        private void gridView1_ColumnChanged(object sender, EventArgs e)
        {
         //   mnWindows.Buttons.
        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            try
            {
                if (e.FocusedColumn == colNext)
                {
                    if (gridView1.OptionsBehavior.Editable == true)
                    {
                        gridView1.AddNewRow();
                        gridView1.FocusedColumn = gridView1.VisibleColumns[0];
                    }
                }
            }
            catch { }
        }
        public void ShowDetailNote()
        {
            if (ID != null)
            {
                gridHangHoa.DataSource = lgNote_Detail.Show_Receipt_Return(ID);
                DataTable dt = (DataTable)gridHangHoa.DataSource;
                if (dt == null)
                    gridView1.AddNewRow();
            }
            else
            {
                gridHangHoa.DataSource = lgNote_Detail.Show_Receipt_Return("-1");
                DataTable dt = (DataTable)gridHangHoa.DataSource;
                gridView1.AddNewRow();
                gridView1.FocusedColumn = gridView1.VisibleColumns[0];
            }
            gridHangHoa.ForceInitialize();
            gridView1.BestFitColumns();
        }
        public void SetCode()
        {
            txtCode.Text = DateTime.Now.ToString("ddmmyyyyhhmmss");
        } 
        private void txtDateAction_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gridHangHoa.Focus();
                ShowDetailNote();
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                    if (XtraMessageBox.Show("Do you want to delete this line?", "Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        gridView1.DeleteSelectedRows();
                    }
            }
        }
        public void ButtonAdd()
        {
            ReadOnlyControl(false);
            ResetControlPhieu();
            mnWindows.Buttons[0].Properties.Enabled = false;
            mnWindows.Buttons[1].Properties.Enabled = true;
            mnWindows.Buttons[2].Properties.Enabled = false;
            mnWindows.Buttons[3].Properties.Enabled = false;
            mnWindows.Buttons[4].Properties.Enabled = false;
            mnWindows.Buttons[6].Properties.Enabled = false;
            ShowListDepartment();
            ShowListDepot();
           
        }
        public void ButtonEdit()
        {
            mnWindows.Buttons[0].Properties.Enabled = true;
            mnWindows.Buttons[1].Properties.Enabled = true;
            mnWindows.Buttons[2].Properties.Enabled = false;
            mnWindows.Buttons[3].Properties.Enabled = false;
            mnWindows.Buttons[4].Properties.Enabled = false;
            mnWindows.Buttons[6].Properties.Enabled = false;
            ReadOnlyControl(false);
        }
        public void ButtonSave()
        {
            mnWindows.Buttons[0].Properties.Enabled = true;
            mnWindows.Buttons[1].Properties.Enabled = false;
            mnWindows.Buttons[2].Properties.Enabled = true;
            mnWindows.Buttons[3].Properties.Enabled = true;
            mnWindows.Buttons[4].Properties.Enabled = true;
            mnWindows.Buttons[6].Properties.Enabled = true;
            ReadOnlyControl(true);
          
        }
        public void ButtonDelete()
        {
            mnWindows.Buttons[0].Properties.Enabled = true;
            mnWindows.Buttons[1].Properties.Enabled = false;
            mnWindows.Buttons[2].Properties.Enabled = false;
            mnWindows.Buttons[3].Properties.Enabled = false;
            mnWindows.Buttons[4].Properties.Enabled = false;
            mnWindows.Buttons[6].Properties.Enabled = true;
            ResetControlPhieu();
            ReadOnlyControl(true);
        }
        public void ButtonFind()
        {
            mnWindows.Buttons[0].Properties.Enabled = true;
            mnWindows.Buttons[1].Properties.Enabled = false;
            mnWindows.Buttons[2].Properties.Enabled = true;
            mnWindows.Buttons[3].Properties.Enabled = true;
            mnWindows.Buttons[6].Properties.Enabled = true;
            ReadOnlyControl(true);
        }
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Delete")
            {
                if (XtraMessageBox.Show("Do you want to delete this line?", "Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    gridView1.DeleteSelectedRows();
                }
            }
        }
        public void ReadOnlyControl(bool kt)
        {
            txtCode.ReadOnly = kt;
            txtDateAction.ReadOnly = kt;
            txtDetail.ReadOnly = kt;
            gridDepot.ReadOnly = kt;
            gridDepartment.ReadOnly = kt;
            gridView1.OptionsBehavior.Editable = !kt;
            if (!kt == true)
            {
                gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            }
            else
            {
                gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            }
        }
        public void ResetControlPhieu()
        {
            txtDetail.Text = "";
            txtDateAction.Text = "";
            txtReceiver.Text = "";
            txtDelivery_person.Text = "";
            IDDepot = null;
            IDDepartment = null;
            txtCode.Text = "";
            ID = null;
        }
        public bool CheckParamemter(LayerObjectData.objNote_ReceiptReturn obj)
        {
            if (obj.Code == "")
            {
                XtraMessageBox.Show("Please enter your code", "Notification!");
                txtCode.Focus();
                return false;
            }
            if (obj.DateAction == "")
            {
                XtraMessageBox.Show("Please enter your date action", "Notification!");
                txtDateAction.Focus();
                return false;
            }
            if(CheckLotID() == false)
            {
                XtraMessageBox.Show("Missing shipment information", "Notification!");
                return false;
            }    
            if (obj.IDDepartment == "" || obj.IDDepartment == null)
            {
                XtraMessageBox.Show("Please select a department", "Notification!");
                gridDepartment.Focus();
                return false;
            }
            if (obj.IDDepot == "" || obj.IDDepot == null)
            {
                XtraMessageBox.Show("Please select a warehouse", "Notification!");
                gridDepot.Focus();
                return false;
            }

            return true;
        }
      
        
        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            //if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
            if (e.Button.Properties.Caption == "New")
            {                
                ResetControlPhieu();
                txtCode.Text = DateTime.Now.ToString("ddmmyyyyhhmmss");
                mnWindows.Buttons[2].Properties.Enabled = false;
                ButtonAdd();
            }
            if (e.Button.Properties.Caption == "Save")
            {               
                DeleteRowsEmpty();
                SetParameter_Procedure(objReceiptReturn);
                if (CheckParamemter(objReceiptReturn) == true)
                {
                    if (ID == null)
                    {
                        if (lgReceiptReturn.InsertData(objReceiptReturn) == true)
                        {
                            ID = lgReceiptReturn.GetID(objReceiptReturn.Code);
                            AddPIDToList(ID);
                            DataTable data = (DataTable)gridHangHoa.DataSource;
                            int dong = data.Rows.Count;
                            lgNote_UpdateData.NoteDataDetail(data, "P_Note_ReceiptReturn", ID);
                            ShowDetailNote();
                            XtraMessageBox.Show("Information saved", "Notification!");
                        }
                        else
                        {
                            XtraMessageBox.Show(" Input information is incorrect", "Notification!");

                        }
                    }// Insert data
                    else
                    {
                        if (lgReceiptReturn.UpdatetData(objReceiptReturn) == true)
                        {                          
                            AddPIDToList(ID);
                            DataTable data = (DataTable)gridHangHoa.DataSource;
                            lgNote_UpdateData.NoteDataDetail(data, "P_Note_ReceiptReturn", ID);
                            ShowDetailNote();
                            XtraMessageBox.Show("Information saved", "Notification!");

                        }else
                        {
                            XtraMessageBox.Show(" Input information is incorrect", "Notification!");
                           
                        }
                    }
                    ReadOnlyControl(true);
                    ButtonSave();
                }
              
            }
            if (e.Button.Properties.Caption == "Edit")
            {
                ButtonEdit();
            }
            if (e.Button.Properties.Caption == "Delete")
            {
                ButtonDelete();
            }
            if (e.Button.Properties.Caption == "Find")
            {
                ButtonFind();
                ImportExport.frmListReceiptFind frm = new frmListReceiptFind();
                frm.setdataFrm = new frmListReceiptFind.SetDataFrom(GetDataFind);
                frm.ShowDialog();
            }
            

        }
        public void GetDataFind(string id, string code, string dateaction, string iddepot, string idsupplier, string detail, string receiver, string delivery_person)
        {
            ID = id;
            txtCode.Text = code;
            txtDateAction.Text = dateaction;
            gridDepot.EditValue = iddepot;
            gridDepartment.EditValue = idsupplier;
            txtDetail.Text = detail;
            txtReceiver.Text = receiver;
            txtDelivery_person.Text = delivery_person;
            ShowDetailNote();
        }
        public void AddPIDToList(string SoHD)
        {
            if (gridView1.RowCount > 0)
            {
                try
                {
                    for (int i = 0; i <= gridView1.RowCount; i++)
                    {
                        gridView1.SetRowCellValue(i, colID, SoHD);
                        gridView1.FocusedRowHandle = -1;
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Không add số phiếu vào list hàng hóa, vui lòng kiểm tra lại", "Thông báo!");
                }
            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (e.Column == colPrice)
            //{
            //    try
            //    {
            //        var format = Thread.CurrentThread.CurrentCulture.NumberFormat;
            //        var decimalDigits = format.NumberDecimalSeparator;
            //        //if (decimalDigits == ".")
            //        //{

            //        //    string a = e.Value.ToString();
            //        //    gridView1.SetRowCellValue(e.RowHandle, colQuantity, a);
            //        //}
            //        //else
            //        //{
            //        //    string a = e.Value.ToString().Substring(1, e.Value.ToString().Length - 3);
            //        //    gridView1.SetRowCellValue(e.RowHandle, colQuantity, a);
            //        //}
            //        float dongia = float.Parse(gridView1.GetRowCellValue(e.RowHandle, colPrice).ToString());
            //        float soluong = float.Parse(gridView1.GetRowCellValue(e.RowHandle, colQuantity).ToString());
            //        try
            //        {

            //            gridView1.SetRowCellValue(e.RowHandle, colThanhTien, (soluong * dongia).ToString());
            //        }
            //        catch { gridView1.SetRowCellValue(e.RowHandle, colThanhTien, "0"); }
            //    }
            //    catch 
            //    {
            //    }
            //}   
        }
        string IDDepartment;
        private void gridSupplier_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                IDDepartment = gridDepartment.EditValue.ToString();
            }
            catch 
            {
                IDDepartment = null;
            }
        }

        public bool CheckLotID()
        {
            bool kt = true;
            gridView1.FocusedRowHandle = -1;
            string sloid;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                sloid = gridView1.GetRowCellValue(i, colIDLot).ToString();
                if (sloid == null || sloid == "")
                {
                    XtraMessageBox.Show("Please select the shipment", "Notification!");
                    gridView1.FocusedRowHandle = i;
                    gridView1.FocusedColumn = gridView1.VisibleColumns[7];
                    kt = false;
                    break;
                }
            }
            return kt;
        }
        public void SetParameter_Procedure(LayerObjectData.objNote_ReceiptReturn obj)
        {
            obj.ID = ID;
            obj.Code = txtCode.Text;
            obj.IDDepartment = IDDepartment;
            obj.IDDepot = IDDepot;
            obj.DateAction = txtDateAction.Text;
            obj.Receiver = txtReceiver.Text;
            obj.Delivery_Person = txtDelivery_person.Text;
            obj.Detail = txtDetail.Text;
            obj.UserAction = UserName;
        }
        private void frmImportNew_Load(object sender, EventArgs e)
        {
            ButtonAdd();
            ShowListDepartment();
            ShowListDepot();
            txtCode.Text = DateTime.Now.ToString("ddmmyyyyhhmmss");
        }
        string IDDepot;
        private void gridDepot_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                IDDepot = gridDepot.EditValue.ToString();
            }
            catch
            {
                IDDepot = null;
            }
        }
    }
}