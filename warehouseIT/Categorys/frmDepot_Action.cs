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
    public partial class frmDepot_Action : DevExpress.XtraEditors.XtraForm
    {
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        public frmDepot_Action()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        string useraction;
        string iddepot, depot_code, depot_name;

        public delegate void HienThiThongTin();
        public HienThiThongTin hinthi;

        LayerLogicData.lgDepot lgDepot = new LayerLogicData.lgDepot();
        LayerObjectData.objDepot objDepot = new LayerObjectData.objDepot();
        public void truyenThamSo(LayerObjectData.objDepot obj)
        {
            obj.IDDepot = iddepot;
            obj.Depot_Code = txtDepot_Code.Text;
            obj.Depot_Name = txtDepot_Name.Text;
            obj.UserAction = useraction;
        }
        public void ResetControl()
        {
            txtDepot_Code.Text = "";
            txtDepot_Name.Text = "";
            txtDepot_Code.Focus();
        }
      //  string ThongBao;
        public bool CheckDataObj(LayerObjectData.objDepot obj)
        {
            if (obj.Depot_Code == "")
            {
                XtraMessageBox.Show("Please enter your Depot Code", "Notification!");
                txtDepot_Code.Focus();
                return false;
            }
            if (obj.Depot_Name == "")
            {
                XtraMessageBox.Show("Please enter your Depot Name", "Notification!");
                txtDepot_Name.Focus();
                return false;
            }
            return true;
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
           
            if (e.Button.Properties.Caption == "Save And Close")
            {
                if (iddepot == null)
                {
                    truyenThamSo(objDepot);
                    if (CheckDataObj(objDepot) == true)
                    {
                        if (lgDepot.InsertData(objDepot) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objDepot);
                    if (CheckDataObj(objDepot) == true)
                    {
                        if (lgDepot.UpdatetData(objDepot) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }
            }
            if (e.Button.Properties.Caption == "Save And New")
            {
                if (iddepot == null)
                {
                    truyenThamSo(objDepot);
                    if (CheckDataObj(objDepot) == true)
                    {
                        if (lgDepot.InsertData(objDepot) == true)
                        {
                            this.hinthi();
                            ResetControl();
                         
                            txtDepot_Code.Focus();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objDepot);
                    if (CheckDataObj(objDepot) == true)
                    {
                        if (lgDepot.UpdatetData(objDepot) == true)
                        {
                            this.hinthi();
                            ResetControl();
                            iddepot = null;
                            txtDepot_Code.Focus();
                        }
                    }
                }
            }
           
        }
      
        private void frmNhomHang_Action_Load(object sender, EventArgs e)
        {

        }

        public void NhanData(string IDDepot, string Depot_Code, string Depot_Name)
        {
            iddepot = IDDepot;

            depot_code = Depot_Code;
            depot_name = Depot_Name;
            txtDepot_Code.Text = depot_code;
            txtDepot_Name.Text = depot_name;
        }
    }
}