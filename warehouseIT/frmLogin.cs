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

namespace warehouseIT
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {

            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        public void ThayDoiNgonNgu()
        {


        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ThayDoiNgonNgu();
        }

        private void radioVN_CheckedChanged(object sender, EventArgs e)
        {
            ThayDoiNgonNgu();
        }

        ClassReference.EncodeMD5 encode = new ClassReference.EncodeMD5();
        public void TruyenThamSoTaiKhoan(LayerObjectData.objUser obj)
        {
            obj.Username = txtTenDangNhap.Text;
            obj.Password = encode.EncodeString(txtMatKhau.Text);
        }
        LayerObjectData.objUser objuser = new LayerObjectData.objUser();
        saveConfigRegedit configregedit = new saveConfigRegedit();
        LayerLogicData.lgUser lgUser = new LayerLogicData.lgUser();
        string isRoot, NhomQID, fullname;
        public delegate void HienThiThongTinDangNhap(string usre, string name, string isroot, string nhomqid);
        public HienThiThongTinDangNhap hienthi;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (CheckLogin(txtTenDangNhap.Text, txtMatKhau.Text) == true)
            {
                this.hienthi(txtTenDangNhap.Text, fullname, isRoot, NhomQID);
                this.Close();
            }
            else XtraMessageBox.Show("Username or password is incorrect", "Notification!");
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap_Click(sender, e);
        }

        public bool CheckLogin(string tendangnhap, string matkhau)
        {
            bool kt = false;
            TruyenThamSoTaiKhoan(objuser);
            configregedit.readFromResgistry();
            if (lgUser.CheckLogIn(tendangnhap, encode.EncodeString(matkhau)) == true)
            {
                DataTable dt = lgUser.GetInforLogin(tendangnhap, encode.EncodeString(matkhau));
                if (dt.Rows.Count > 0)
                {
                    isRoot = dt.Rows[0]["IsRoot"].ToString();
                    NhomQID = dt.Rows[0]["IDUserGr"].ToString();
                    configregedit.savelogin(tendangnhap, dt.Rows[0]["Fullname"].ToString(), dt.Rows[0]["IsRoot"].ToString(), dt.Rows[0]["IDUserGr"].ToString());
                    fullname = dt.Rows[0]["Fullname"].ToString();
                }
                kt = true;
            }
            else kt = false;
            return kt;
        } 
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}