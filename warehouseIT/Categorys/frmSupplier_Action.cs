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
    public partial class frmSupplier_Action : DevExpress.XtraEditors.XtraForm
    {
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        public frmSupplier_Action()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        string useraction;
        string IDSupplier;

        public delegate void HienThiThongTin();
        public HienThiThongTin hinthi;

        LayerLogicData.lgSupplier lgSupplier = new LayerLogicData.lgSupplier();
        LayerObjectData.objSupplier objSupplier = new LayerObjectData.objSupplier();
        public void truyenThamSo(LayerObjectData.objSupplier obj)
        {
            obj.IDSupplier = IDSupplier;
            obj.Supplier_Code= txtSupplier_Code.Text;
            obj.Supplier_Name = txtSupplier_Name.Text;
            obj.Supplier_Addresss = txtSupplier_Address.Text;
            obj.Supplier_Email = txtSupplier_Email.Text;
            obj.Supplier_Phone = txtSupplier_Phone.Text;
            obj.UserAction = useraction;
        }
        public void ResetControl()
        {
            txtSupplier_Code.Text = "";
            txtSupplier_Name.Text = "";
            txtSupplier_Address.Text = "";
            txtSupplier_Email.Text = "";
            txtSupplier_Phone.Text = "";
            txtSupplier_Code.Focus();
        }
      //  string ThongBao;
        public bool CheckDataObj(LayerObjectData.objSupplier obj)
        {
            if (obj.Supplier_Code == "")
            {
                XtraMessageBox.Show("Please enter your Supplier Code", "Notification!");
                txtSupplier_Code.Focus();
                return false;
            }
            if (obj.Supplier_Name == "")
            {
                XtraMessageBox.Show("Please enter your Supplier Name", "Notification!");
                txtSupplier_Name.Focus();
                return false;
            }
            return true;
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
           
            if (e.Button.Properties.Caption == "Save And Close")
            {
                if (IDSupplier == null)
                {
                    truyenThamSo(objSupplier);
                    if (CheckDataObj(objSupplier) == true)
                    {
                        if (lgSupplier.InsertData(objSupplier) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objSupplier);
                    if (CheckDataObj(objSupplier) == true)
                    {
                        if (lgSupplier.UpdatetData(objSupplier) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }
            }
            if (e.Button.Properties.Caption == "Save And New")
            {
                if (IDSupplier == null)
                {
                    truyenThamSo(objSupplier);
                    if (CheckDataObj(objSupplier) == true)
                    {
                        if (lgSupplier.InsertData(objSupplier) == true)
                        {
                            this.hinthi();
                            ResetControl();
                         
                            txtSupplier_Code.Focus();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objSupplier);
                    if (CheckDataObj(objSupplier) == true)
                    {
                        if (lgSupplier.UpdatetData(objSupplier) == true)
                        {
                            this.hinthi();
                            ResetControl();
                            IDSupplier = null;
                            txtSupplier_Code.Focus();
                        }
                    }
                }
            }
            if (e.Button.Properties.Caption == "Delete")
            {
                XtraMessageBox.Show("Delete");
                if (IDSupplier != null)
                {
                    lgSupplier.DeleteData(IDSupplier, useraction);
                   
                }
            }
        }
      
        private void frmNhomHang_Action_Load(object sender, EventArgs e)
        {

        }

        public void NhanData(string idsupplier, string supplier_code, string supplier_name, string supplier_address, string supplier_phone, string supplier_email)
        {
            IDSupplier = idsupplier;
            txtSupplier_Code.Text = supplier_code;
            txtSupplier_Name.Text = supplier_name;
            txtSupplier_Address.Text = supplier_address;
            txtSupplier_Email.Text = supplier_email;
            txtSupplier_Phone.Text = supplier_phone;
        }
    }
}