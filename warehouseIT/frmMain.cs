using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace warehouseIT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
          
           
            InitializeComponent();
           
        }
        #region Action TabControl
        private static bool checkTabcontrol(DevExpress.XtraTab.XtraTabControl TabControlName, string TabName)
        {
            bool kt = false;
            for (int i = 0; i < TabControlName.TabPages.Count; i++)
            {
                if (TabControlName.TabPages[i].Name == TabName)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        private void tabHienThi_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabControl TabControl = (XtraTabControl)sender;
            int i = TabControl.SelectedTabPageIndex;
            TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
            TabControl.SelectedTabPageIndex = i - 1;
        }
        public void AddTab(Form frm, string Name, string NameShow)
        {
            DevExpress.XtraTab.XtraTabPage page = new DevExpress.XtraTab.XtraTabPage();
            page.Text = NameShow;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
            page.Name = Name;
            page.Controls.Add(frm);
            tabHienThi.TabPages.Add(page);
            tabHienThi.SelectedTabPage = page;
            frm.Focus();
        }
        public int IndexTab(string nameTab)
        {
            int vt = 0;
            for (int i = 0; i < tabHienThi.TabPages.Count; i++)
            {
                if (tabHienThi.TabPages[i].Name == nameTab)
                {
                    vt = i;
                    break;
                }
                continue;
            }
            return vt;
        }
        public void ShowfrominTab(string NameTab, DevExpress.XtraEditors.XtraForm Namefrom, string captionTab)
        {
            try
            {
                if (checkTabcontrol(tabHienThi, NameTab) == true)
                {
                    int index = IndexTab(NameTab);
                    tabHienThi.SelectedTabPage = tabHienThi.TabPages[index];
                    tabHienThi.TabPages[index].Refresh();
                    tabHienThi.TabPages[index].Invalidate();
                    tabHienThi.Focus();
                }
                else
                {
                    AddTab(Namefrom, NameTab, captionTab);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnNhomHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Category.frmProductGr frm = new Category.frmProductGr();
            ShowfrominTab(frm.Name, frm, btnNhomHang.Caption.ToUpper());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            KhoaChuNang(false);
            DisbleMenu(false);
            frmLogin frm = new frmLogin();
            frm.hienthi = new frmLogin.HienThiThongTinDangNhap(HienThiThongTinTaiKhoan);
            frm.ShowDialog();
        }
        private void KhoaChuNang(bool tk)
        {
            var tt = BarItemVisibility.Always;
            if (tk == true)
            {
                tt = BarItemVisibility.Always;
            }
            else tt = BarItemVisibility.Never;
            btnDanhSachNhapKho.Visibility = tt;
            btnDanhSachNhapTraLai.Visibility = tt;
            btnDanhSachXuatKho.Visibility = tt;
            btnDanhSachXuatTraLai.Visibility = tt;
            btnDSKiemKeKho.Visibility = tt;
            btnHangHoa.Visibility = tt;
            btnKiemKeKho.Visibility = tt;
            btnKiemTonKho.Visibility = tt;
            btnNguoiDung.Visibility = tt;
            btnNhanVien.Visibility = tt;
            btnNhapKho.Visibility = tt;
            btnNhapTraLai.Visibility = tt;
            btnNhomHang.Visibility = tt;
            btnNhomQuyen.Visibility = tt;
            btnPhanQuyen.Visibility = tt;
            btnPhongBan.Visibility = tt;
            btnQuyen.Visibility = tt;
            btnTheKho.Visibility = tt;
            btnTongHopNhapXuatTon.Visibility = tt;
            btnXuatKho.Visibility = tt;
            btnXuatTraLai.Visibility = tt;
            btnKhoHang.Visibility = tt;
            btnLotNo.Visibility = tt;
            btnBCCapPhat.Visibility = tt;
            btnTongHopPhongBan.Visibility = tt;

        }
        public void HienThiMenu(string cn)
        {
            if (cn == "1")
                mmHeThong.Visible = true;
            if (cn == "2")
                mmDanhMuc.Visible = true;
            if (cn == "3")
                mmNhapXuatKho.Visible = true;
            if (cn == "4")
                mmBaoCaoThongKe.Visible = true;
        }
        public void OpenButtonControl(string TenCN, bool kt)
        {
            var abc = BarItemVisibility.Always;
            if (kt == true)
            {
                abc = BarItemVisibility.Always;
            }
            else
            {
                abc = BarItemVisibility.Never;
            }
            switch (TenCN)
            {
                case "btnDanhSachNhapKho":
                    btnDanhSachNhapKho.Visibility = abc;
                    break;
                case "btnDanhSachNhapTraLai":
                    btnDanhSachNhapTraLai.Visibility = abc;
                    break;
                case "btnDanhSachXuatKho":
                    btnDanhSachXuatKho.Visibility = abc;
                    break;
                case "btnDanhSachXuatTraLai":
                    btnDanhSachXuatTraLai.Visibility = abc;
                    break;
                case "btnDSKiemKeKho":
                    btnDSKiemKeKho.Visibility = abc;
                    break;
                case "btnHangHoa":
                    btnHangHoa.Visibility = abc;
                    break;
                case "btnKiemKeKho":
                    btnKiemKeKho.Visibility = abc;
                    break;
                case "btnKiemTonKho":
                    btnKiemTonKho.Visibility = abc;
                    break;
                case "btnNguoiDung":
                    btnNguoiDung.Visibility = abc;
                    break;
                case "btnNhanVien":
                    btnNhanVien.Visibility = abc;
                    break;
                case "btnNhapKho":
                    btnNhapKho.Visibility = abc;
                    break;
                case "btnNhapTraLai":
                    btnNhapTraLai.Visibility = abc;
                    break;
                case "btnNhomHang":
                    btnNhomHang.Visibility = abc;
                    break;
                case "btnNhomQuyen":
                    btnNhomQuyen.Visibility = abc;
                    break;
                case "btnPhanQuyen":
                    btnPhanQuyen.Visibility = abc;
                    break;
                case "btnPhongBan":
                    btnPhongBan.Visibility = abc;
                    break;
                case "btnQuyen":
                    btnQuyen.Visibility = abc;
                    break;
                case "btnTheKho":
                    btnTheKho.Visibility = abc;
                    break;
                case "btnTongHopNhapXuatTon":
                    btnTongHopNhapXuatTon.Visibility = abc;
                    break;
                case "btnKhoHang":
                    btnKhoHang.Visibility = abc;
                    break;
                case "btnLotNo":
                    btnLotNo.Visibility = abc;
                    break;
                case "btnBCCapPhat":
                    btnBCCapPhat.Visibility = abc;
                    break;
                case "btnTongHopPhongBan":
                    btnTongHopPhongBan.Visibility = abc;
                    break;
            }
        }
        public void HienThiThongTinTaiKhoan(string username, string fullname, string root, string nhomquyen)
        {
            lbTenNguoiDung.Caption = string.Format("{0} : {1}", username, fullname);
            if (root == "False")
            {
                LayerLogicData.lgGantPermission lgphanquyen = new LayerLogicData.lgGantPermission();
                DataTable dsmenu = lgphanquyen.ShowListMenu(nhomquyen);
                if (dsmenu.Rows.Count > 0)
                {
                    DisbleMenu(false);
                    string a = "";
                    for (int i = 0; i < dsmenu.Rows.Count; i++)
                    {
                        a = dsmenu.Rows[i]["MenuID"].ToString();
                        HienThiMenu(a);
                    }
                }
                DataTable DSCN = lgphanquyen.ShowListChucNang(nhomquyen);
                if (DSCN.Rows.Count > 0)
                {
                    string b = "";
                    for (int i = 0; i < DSCN.Rows.Count; i++)
                    {
                        b = DSCN.Rows[i]["MaCN"].ToString();
                        OpenButtonControl(b, true);
                    }
                }
            }
            else
            {
                KhoaChuNang(true);
                DisbleMenu(true);
            }
        }
        private void DisbleMenu(bool kt)
        {
            mmHeThong.Visible = kt;
            mmDanhMuc.Visible = kt;
            mmNhapXuatKho.Visible = kt;
            mmBaoCaoThongKe.Visible = kt;
        }
        private void btnChangeLanguage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLanguage frm = new frmLanguage();
            frm.ShowDialog();
        }

        private void btnNhomQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            SystemsAdmin.frmGroupUser frm = new SystemsAdmin.frmGroupUser();
            ShowfrominTab(frm.Name, frm, btnNhomQuyen.Caption.ToUpper());
        }

        private void btnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            SystemsAdmin.frmUser frm = new SystemsAdmin.frmUser();
            ShowfrominTab(frm.Name, frm, btnNguoiDung.Caption.ToUpper());
        }

        private void btnHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Category.frmProduct frm = new Category.frmProduct();
            ShowfrominTab(frm.Name, frm, btnHangHoa.Caption.ToUpper());
        }

        private void btnNhapKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportExport.frmImportNew frm = new ImportExport.frmImportNew();
            ShowfrominTab(frm.Name, frm, btnNhapKho.Caption.ToUpper());
        }

        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            SystemsAdmin.frmGrantPermission frm = new SystemsAdmin.frmGrantPermission();
            ShowfrominTab(frm.Name, frm, btnPhanQuyen.Caption.ToUpper());
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            tabHienThi.TabPages.Clear();
            DisbleMenu(false);
            KhoaChuNang(false);
            lbTenNguoiDung.Caption = "";
            frmLogin frm = new frmLogin();
            frm.hienthi = new frmLogin.HienThiThongTinDangNhap(HienThiThongTinTaiKhoan);
            frm.ShowDialog();
        }

        private void btnKhoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Category.frmDepot frm = new Category.frmDepot();
            ShowfrominTab(frm.Name, frm, btnKhoHang.Caption.ToUpper());
        }

        private void btnPhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Category.frmDepartment frm = new Category.frmDepartment();
            ShowfrominTab(frm.Name, frm, btnPhongBan.Caption.ToUpper());
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Category.frmEmployee frm = new Category.frmEmployee();
            ShowfrominTab(frm.Name, frm, btnNhanVien.Caption.ToUpper());
        }

        private void btnQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            SystemsAdmin.frmPermission frm = new SystemsAdmin.frmPermission();
            ShowfrominTab(frm.Name, frm, btnQuyen.Caption.ToUpper());
        }

        private void btnLotNo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Category.frmListLot frm = new Category.frmListLot();
            ShowfrominTab(frm.Name, frm, btnLotNo.Caption.ToUpper());
        }

        private void btnSupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            Category.frmSupplier frm = new Category.frmSupplier();
            ShowfrominTab(frm.Name, frm, btnSupplier.Caption.ToUpper());
        }

        private void btnDanhSachNhapKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportExport.frmListReceipt frm = new ImportExport.frmListReceipt();
            ShowfrominTab(frm.Name, frm, btnDanhSachNhapKho.Caption.ToUpper());
        }

        private void btnXuatKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportExport.frmExportAllocation frm = new ImportExport.frmExportAllocation();
            ShowfrominTab(frm.Name, frm, btnXuatKho.Caption.ToUpper());
        }

        private void btnTongHopNhapXuatTon_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmInventory frm = new frmInventory();
            ShowfrominTab(frm.Name, frm, btnTongHopNhapXuatTon.Caption.ToUpper());
        }

        private void btnDanhSachXuatKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportExport.frmListAllocation frm = new ImportExport.frmListAllocation();
            ShowfrominTab(frm.Name, frm, btnDanhSachXuatKho.Caption.ToUpper());
        }

        private void btnNhapTraLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportExport.frmImportReturn frm = new ImportExport.frmImportReturn();
            ShowfrominTab(frm.Name, frm, btnNhapTraLai.Caption.ToUpper());
        }

        private void btnDanhSachNhapTraLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportExport.frmListReturn frm = new ImportExport.frmListReturn();
            ShowfrominTab(frm.Name, frm, btnDanhSachNhapTraLai.Caption.ToUpper());
        }

        private void btnXuatTraLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportExport.frmExportReturn frm = new ImportExport.frmExportReturn();
            ShowfrominTab(frm.Name, frm, btnXuatTraLai.Caption.ToUpper());
        }

        private void btnTheKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmWarehouseCard frm = new frmWarehouseCard();
            ShowfrominTab(frm.Name, frm, btnTheKho.Caption.ToUpper());
        }

        private void btnDanhSachXuatTraLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportExport.frmListExReturn frm = new ImportExport.frmListExReturn();
            ShowfrominTab(frm.Name, frm, btnDanhSachXuatTraLai.Caption.ToUpper());
        }

        private void btnKiemKeKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportExport.frmKiemKe frm = new ImportExport.frmKiemKe();
            ShowfrominTab(frm.Name, frm, btnKiemKeKho.Caption.ToUpper());
        }
    }
}
