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

namespace warehouseIT.SystemsAdmin
{
    public partial class frmUser_Action : DevExpress.XtraEditors.XtraForm
    {
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        public frmUser_Action()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        string useraction;
        string idUser, tendangnhap, tenhienthi;

        public delegate void HienThiThongTin();
        public HienThiThongTin hinthi;

        LayerLogicData.lgUser lgUser = new LayerLogicData.lgUser();
        LayerObjectData.objUser objUser = new LayerObjectData.objUser();
        ClassReference.EncodeMD5 encodeMD = new ClassReference.EncodeMD5();
        public void truyenThamSo(LayerObjectData.objUser obj)
        {
            obj.UserID = idUser;
            obj.Password = encodeMD.EncodeString(txtMatKhau.Text);
            obj.Username = txtTenDangNhap.Text;
            obj.Fullname = txtTenHienThi.Text;
            obj.UserAction = useraction;
            obj.IDUserGr = idNhomQuyen;
        }
        public void ResetControl()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtXacNhanMatKhau.Text = "";
        }
      
        public bool CheckDataObj(LayerObjectData.objUser obj)
        {
            if (obj.Username == "")
            {
                XtraMessageBox.Show("Please enter your username", "Notification!");
                txtTenDangNhap.Focus();
                return false;
            }
            if (obj.Password =="")
            {
                XtraMessageBox.Show("Please enter your password", "Notification!");
                txtMatKhau.Focus();
                return false;
            }
            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                XtraMessageBox.Show("Confirmation password is not correct", "Notification!");
                txtXacNhanMatKhau.Focus();
                return false;
            }
            return true;
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Save And Close")
            {
                if (idUser == null)
                {
                    truyenThamSo(objUser);
                    if (CheckDataObj(objUser) == true)
                    {
                        if (lgUser.InsertData(objUser) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }else
                {

                }
            }
            if (e.Button.Properties.Caption == "Save And New")
            {
                if (idUser == null)
                {
                    truyenThamSo(objUser);
                    if (CheckDataObj(objUser) == true)
                    {
                        if (lgUser.InsertData(objUser) == true)
                        {
                            this.hinthi();
                            ResetControl();
                        }
                    }
                }
                else
                {

                }
            }
        }
        LayerLogicData.lgUserGruop lgnhomquyen = new LayerLogicData.lgUserGruop();
        public void HienThiNhomQuyen()
        {
            gridNhomQuyen.Properties.DataSource = lgnhomquyen.ShowListData();
        }

        private void windowsUIButtonPanelMain_Click(object sender, EventArgs e)
        {

        }
        string idNhomQuyen;
        private void gridNhomQuyen_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                idNhomQuyen = gridNhomQuyen.EditValue.ToString();
            }
            catch 
            {
                idNhomQuyen = null;
            }

        }

        private void frmNhomHang_Action_Load(object sender, EventArgs e)
        {
            HienThiNhomQuyen();
        }

        public void NhanData(string IDNhomHang, string MaNhom, string TenNhom)
        {
            idUser = IDNhomHang;
            tendangnhap = MaNhom;
            tenhienthi = TenNhom;
        }
    }
}