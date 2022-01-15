using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouseIT.Category
{
    public partial class frmListLot_Action : DevExpress.XtraEditors.XtraForm
    {
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        public frmListLot_Action()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        string useraction;
        string idlistlot, idproduct, serial, dateproduction, detail;

        public delegate void HienThiThongTin(string idproduct);
        public HienThiThongTin hinthi;

        LayerLogicData.lgListLot lgList = new LayerLogicData.lgListLot();
        LayerObjectData.objListLot objListLot = new LayerObjectData.objListLot();
        public void truyenThamSo(LayerObjectData.objListLot obj)
        {
            obj.IDLot = idlistlot;
            obj.Serial = txtSerial.Text;
            obj.IDProduct = idproduct;
            obj.LotNumber = txtLotNumber.Text;
            obj.Detail = txtDetail.Text;
            obj.DateProduction = txtDateProduction.Text;
            obj.UserAction = useraction;
        }
        public void ResetControl()
        {
            txtSerial.Text = "";
            txtDateProduction.Text = "";
            txtDetail.Text = "";
            txtSerial.Focus();
        }
      //  string ThongBao;
        public bool CheckDataObj(LayerObjectData.objListLot obj)
        {
            if (obj.LotNumber == "")
            {
                XtraMessageBox.Show("Please enter your LotNumber", "Notification!");
                txtLotNumber.Focus();
                return false;
            }
            return true;
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
           
            if (e.Button.Properties.Caption == "Save And Close")
            {
                if (idlistlot == null)
                {
                    truyenThamSo(objListLot);
                    if (CheckDataObj(objListLot) == true)
                    {
                        if (lgList.InsertData(objListLot) == true)
                        {
                            this.hinthi(idproduct);
                            this.Close();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objListLot);
                    if (CheckDataObj(objListLot) == true)
                    {
                        if (lgList.UpdatetData(objListLot) == true)
                        {
                            this.hinthi(idproduct);
                            this.Close();
                        }
                    }
                }
            }
            if (e.Button.Properties.Caption == "Save And New")
            {
                if (idlistlot == null)
                {
                    truyenThamSo(objListLot);
                    if (CheckDataObj(objListLot) == true)
                    {
                        if (lgList.InsertData(objListLot) == true)
                        {
                            this.hinthi(idproduct);
                            ResetControl();
                         
                            txtSerial.Focus();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objListLot);
                    if (CheckDataObj(objListLot) == true)
                    {
                        if (lgList.UpdatetData(objListLot) == true)
                        {
                            this.hinthi(idproduct);
                            ResetControl();
                            idlistlot = null;
                            txtSerial.Focus();
                        }
                    }
                }
            }
           
        }
      
        private void frmNhomHang_Action_Load(object sender, EventArgs e)
        {

        }

        public void NhanData(string IDListlot, string IDProduct, string DateProduction, string Serial, string Detail)
        {
            idlistlot = IDListlot;
            idproduct = IDProduct;
            dateproduction = DateProduction;
            serial = Serial;
            detail = Detail;
        }
    }
}