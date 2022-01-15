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
    public partial class frmGroupUser_Action : DevExpress.XtraEditors.XtraForm
    {
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        public frmGroupUser_Action()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        string useraction;
        string idnhomquyen, manhom, tennhom;

        public delegate void HienThiThongTin();
        public HienThiThongTin hinthi;

        LayerLogicData.lgUserGruop lgnhomquyen = new LayerLogicData.lgUserGruop();
        LayerObjectData.objUserGroup objNhomQuyen = new LayerObjectData.objUserGroup();
        public void truyenThamSo(LayerObjectData.objUserGroup obj)
        {
            obj.IDUserGr = idnhomquyen;

            obj.UserGr_Code = txtMaNhomQuyen.Text;
            obj.UserGr_Name = txtTenNhomQuyen.Text;
            obj.UserAction = useraction;
        }
        public void ResetControl()
        {
            txtMaNhomQuyen.Text = "";
            txtTenNhomQuyen.Text = "";
            txtMaNhomQuyen.Focus();
        }
    
        public bool CheckDataObj(LayerObjectData.objUserGroup obj)
        {
            if (obj.UserGr_Code == "")
            {
               // XtraMessageBox.Show(, "Thông báo");
                txtMaNhomQuyen.Focus();
                return false;
            }
            if (obj.UserGr_Name == "")
            {
                //XtraMessageBox.Show("Vui lòng nhập tên khoản mục chi", "Thông báo");
                //txtTenNhom.Focus();
                return false;
            }
            return true;
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Save And Close")
            {
                if (idnhomquyen == null)
                {
                    truyenThamSo(objNhomQuyen);
                    if (CheckDataObj(objNhomQuyen) == true)
                    {
                        if (lgnhomquyen.InsertData(objNhomQuyen) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }else
                {
                    truyenThamSo(objNhomQuyen);
                    if (CheckDataObj(objNhomQuyen) == true)
                    {
                        if (lgnhomquyen.UpdatetData(objNhomQuyen) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }
            }
            if (e.Button.Properties.Caption == "Save And New")
            {
                if (idnhomquyen == null)
                {
                    truyenThamSo(objNhomQuyen);
                    if (CheckDataObj(objNhomQuyen) == true)
                    {
                        if (lgnhomquyen.InsertData(objNhomQuyen) == true)
                        {
                            this.hinthi();
                            txtTenNhomQuyen.Text = "";
                            txtMaNhomQuyen.Text = "";
                            txtMaNhomQuyen.Focus();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objNhomQuyen);
                    if (CheckDataObj(objNhomQuyen) == true)
                    {
                        txtMaNhomQuyen.ReadOnly = true;
                        if (lgnhomquyen.UpdatetData(objNhomQuyen) == true)
                        {
                            this.hinthi();
                            this.Close();
                            txtTenNhomQuyen.Text = "";
                            txtMaNhomQuyen.ReadOnly = false;
                            txtMaNhomQuyen.Text = "";
                            txtMaNhomQuyen.Focus();
                        }
                    }
                }
            }
        }

        private void frmNhomHang_Action_Load(object sender, EventArgs e)
        {
            txtMaNhomQuyen.Text = manhom;
            txtTenNhomQuyen.Text = tennhom;
           
        }

        public void NhanData(string IDNhomHang, string MaNhom, string TenNhom)
        {
            idnhomquyen = IDNhomHang;
            manhom = MaNhom;
            tennhom = TenNhom;
        }
    }
}