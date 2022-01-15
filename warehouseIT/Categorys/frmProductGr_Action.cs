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
    public partial class frmProductGr_Action : DevExpress.XtraEditors.XtraForm
    {
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        public frmProductGr_Action()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        string useraction;
        string idnhomhang, manhom, tennhom;

        public delegate void HienThiThongTin();
        public HienThiThongTin hinthi;

        LayerLogicData.lgProductGr lgnhomhang = new LayerLogicData.lgProductGr();
        LayerObjectData.objProductGr objnhomhang = new LayerObjectData.objProductGr();
        public void truyenThamSo(LayerObjectData.objProductGr obj)
        {
            obj.IDProductGr = idnhomhang;
            obj.ProductGr_Code = txtMaNhom.Text;
            obj.ProductGr_Name = txtTenNhom.Text;
            obj.UserAction = useraction;
        }
        public void ResetControl()
        {
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";
            txtMaNhom.Focus();
        }
      //  string ThongBao;
        public bool CheckDataObj(LayerObjectData.objProductGr obj)
        {
            if (obj.ProductGr_Code == "")
            {
                XtraMessageBox.Show("Please enter your Group Code", "Notification!");
                txtMaNhom.Focus();
                return false;
            }
            if (obj.ProductGr_Name == "")
            {
                XtraMessageBox.Show("Please enter your Group Name", "Notification!");
                txtTenNhom.Focus();
                return false;
            }
            return true;
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
           
            if (e.Button.Properties.Caption == "Save And Close")
            {
                if (idnhomhang == null)
                {
                    truyenThamSo(objnhomhang);
                    if (CheckDataObj(objnhomhang) == true)
                    {
                        if (lgnhomhang.InsertData(objnhomhang) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objnhomhang);
                    if (CheckDataObj(objnhomhang) == true)
                    {
                        if (lgnhomhang.UpdatetData(objnhomhang) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }
            }
            if (e.Button.Properties.Caption == "Save And New")
            {
                if (idnhomhang == null)
                {
                    truyenThamSo(objnhomhang);
                    if (CheckDataObj(objnhomhang) == true)
                    {
                        if (lgnhomhang.InsertData(objnhomhang) == true)
                        {
                            this.hinthi();
                            ResetControl();
                         
                            txtMaNhom.Focus();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objnhomhang);
                    if (CheckDataObj(objnhomhang) == true)
                    {
                        if (lgnhomhang.UpdatetData(objnhomhang) == true)
                        {
                            this.hinthi();
                            ResetControl();
                            idnhomhang = null;
                            txtMaNhom.Focus();
                        }
                    }
                }
            }
            if (e.Button.Properties.Caption == "Delete")
            {
                XtraMessageBox.Show("Delete");
                if (idnhomhang != null)
                {
                   // lgnhomhang.DeleteData(idnhomhang, useraction);
                }
            }
        }
      
        private void frmNhomHang_Action_Load(object sender, EventArgs e)
        {

        }

        public void NhanData(string IDNhomHang, string MaNhom, string TenNhom)
        {
            idnhomhang = IDNhomHang;

            manhom = MaNhom;
            txtMaNhom.Text = manhom;
            tennhom = TenNhom;
            txtTenNhom.Text = tennhom;
        }
    }
}