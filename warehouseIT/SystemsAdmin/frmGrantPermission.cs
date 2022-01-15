using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouseIT.SystemsAdmin
{
    public partial class frmGrantPermission : DevExpress.XtraEditors.XtraForm
    {
        public frmGrantPermission()
        {
            InitializeComponent();
        }
        string NhomQuyenID;
        LayerLogicData.lgUserGruop lgDMNhomQuyen = new LayerLogicData.lgUserGruop();
        LayerLogicData.lgGantPermission lgPhanQuyen = new LayerLogicData.lgGantPermission();
        public void HienThiChucNang(string NhomID)
        {
            gridDSChucNang.DataSource = lgPhanQuyen.ShowListData(NhomID);
            gridView2.BestFitColumns();
        }
        public void HienThiNhomQuyen()
        {
            gridDMNhomQuyen.DataSource = lgDMNhomQuyen.ShowListData();
            
            try
            {
                NhomQuyenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDUserGr).ToString();
                lgPhanQuyen.InsertChucNang(NhomQuyenID);
                HienThiChucNang(NhomQuyenID);
            }
            catch
            {
                NhomQuyenID = null;
            }
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            HienThiNhomQuyen();
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Refresh")
            {
                HienThiNhomQuyen();
            }
           
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Save")
            {
                if (NhomQuyenID != null)
                {
                    DataTable dt = (DataTable)gridDSChucNang.DataSource;
                    lgPhanQuyen.UpdateDSChucNang(dt, NhomQuyenID);
                    XtraMessageBox.Show("Saved data");
                }
                else XtraMessageBox.Show("Please select permission group","Notification!");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                NhomQuyenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDUserGr).ToString();
                lgPhanQuyen.InsertChucNang(NhomQuyenID);
                HienThiChucNang(NhomQuyenID);
            }
            catch
            {
                NhomQuyenID = null;
            }
        }
    }
}