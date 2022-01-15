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
    public partial class frmProduct_Action : DevExpress.XtraEditors.XtraForm
    {
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        public frmProduct_Action()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        string useraction;
        string IDNhomHang,IDHang;

        public delegate void HienThiThongTin();
        public HienThiThongTin hinthi;

        LayerLogicData.lgProductGr lgnhomhang = new LayerLogicData.lgProductGr();

        LayerLogicData.lgProduct lgHangHoa = new LayerLogicData.lgProduct();
        LayerObjectData.objProduct objHangHoa = new LayerObjectData.objProduct();
        public void HienThiNhomHang()
        {
            gridNhomHang.Properties.DataSource = lgnhomhang.ShowListData();
        }
        public void truyenThamSo(LayerObjectData.objProduct obj)
        {
            obj.IDProduct = IDHang;
            obj.Product_Code = txtMaHang.Text;
            obj.Product_Name = txtTenHang.Text;
            obj.Product_Detail = txtMoTa.Text;
            obj.Product_Manufacturer = txtHangSanXuat.Text;
            obj.Product_Country = txtNuocSanXuat.Text;
            obj.Product_Unit = txtDonViTinh.Text;
            obj.Product_Price = txtDonGia.Text;
            obj.IDProductGr = IDNhomHang;
            obj.UserAction = useraction;
        }
        public void ResetControl()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtHangSanXuat.Text = "";
            txtNuocSanXuat.Text = "";
            txtMoTa.Text = "";
            txtDonViTinh.Text = "";
            txtDonGia.Text = "";
            txtMaHang.Focus();
        }
      //  string ThongBao;
        public bool CheckDataObj(LayerObjectData.objProduct obj)
        {
            if (obj.Product_Code == "")
            {
                XtraMessageBox.Show("Please enter your Produce Code", "Notification!");
                txtMaHang.Focus();
                return false;
            }
            if (obj.Product_Name == "")
            {
                XtraMessageBox.Show("Please enter your Produce Name", "Notification!");
                txtTenHang.Focus();
                return false;
            }
            if (obj.Product_Unit == "")
            {
                XtraMessageBox.Show("Please enter your Unit", "Notification!");
                txtDonViTinh.Focus();
                return false;
            }
            return true;
        }

        private void gridNhomHang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                IDNhomHang = gridNhomHang.EditValue.ToString();

            }
            catch 
            {
                IDNhomHang = null;
            }
        }

        private void windowsUIButtonPanelMain_Click(object sender, EventArgs e)
        {

        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
           
            if (e.Button.Properties.Caption == "Save & Close")
            {
                if (IDHang == null)
                {
                    truyenThamSo(objHangHoa);
                    if (CheckDataObj(objHangHoa) == true)
                    {
                        if (lgHangHoa.InsertData(objHangHoa) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objHangHoa);
                    if (CheckDataObj(objHangHoa) == true)
                    {
                        if (lgHangHoa.UpdatetData(objHangHoa) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }
            }
            if (e.Button.Properties.Caption == "Save & New")
            {
                if (IDHang == null)
                {
                    truyenThamSo(objHangHoa);
                    if (CheckDataObj(objHangHoa) == true)
                    {
                        if (lgHangHoa.InsertData(objHangHoa) == true)
                        {
                            this.hinthi();
                            ResetControl();
                         
                            txtMaHang.Focus();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objHangHoa);
                    if (CheckDataObj(objHangHoa) == true)
                    {
                        if (lgHangHoa.UpdatetData(objHangHoa) == true)
                        {
                            this.hinthi();
                            ResetControl();
                            IDHang = null;
                            txtMaHang.Focus();
                        }
                    }
                }
            }
            if (e.Button.Properties.Caption == "Delete")
            {
                XtraMessageBox.Show("Delete");
                if (IDHang != null)
                {
                   // lgnhomhang.DeleteData(idnhomhang, useraction);
                }
            }
        }
      
        private void frmNhomHang_Action_Load(object sender, EventArgs e)
        {
            HienThiNhomHang();
        }

        public void NhanData(string idhang,string mahang, string tenhang, string mota, string hangsanxuat, string nuocsanxuat, string donvitinh,string dongia,string nhomID)
        {
            IDHang = idhang;
            IDNhomHang = nhomID;
            gridNhomHang.EditValue = nhomID;
            txtMaHang.Text = mahang;
            txtTenHang.Text = tenhang;
            txtMoTa.Text = mota;
            txtHangSanXuat.Text = hangsanxuat;
            txtNuocSanXuat.Text = nuocsanxuat;
            txtDonViTinh.Text = donvitinh;
            txtDonGia.Text = dongia;
        }
    }
}