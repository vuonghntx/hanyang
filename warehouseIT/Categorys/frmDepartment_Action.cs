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
    public partial class frmDepartment_Action : DevExpress.XtraEditors.XtraForm
    {
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        public frmDepartment_Action()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        string useraction;
        string iddepartment, department_code, department_name;

        public delegate void HienThiThongTin();
        public HienThiThongTin hinthi;

        LayerLogicData.lgDepartment lgDepartment = new LayerLogicData.lgDepartment();
        LayerObjectData.objDepartment objDepartment = new LayerObjectData.objDepartment();
        public void truyenThamSo(LayerObjectData.objDepartment obj)
        {
            obj.IDDepartment = iddepartment;
            obj.Department_Code = txtDepartment_Code.Text;
            obj.Department_Name = txtDepartment_Name.Text;
            obj.UserAction = useraction;
        }
        public void ResetControl()
        {
            txtDepartment_Code.Text = "";
            txtDepartment_Name.Text = "";
            txtDepartment_Code.Focus();
        }
      //  string ThongBao;
        public bool CheckDataObj(LayerObjectData.objDepartment obj)
        {
            if (obj.Department_Code == "")
            {
                XtraMessageBox.Show("Please enter your Department Code", "Notification!");
                txtDepartment_Code.Focus();
                return false;
            }
            if (obj.Department_Name == "")
            {
                XtraMessageBox.Show("Please enter your Department Name", "Notification!");
                txtDepartment_Name.Focus();
                return false;
            }
            return true;
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
           
            if (e.Button.Properties.Caption == "Save And Close")
            {
                if (iddepartment == null)
                {
                    truyenThamSo(objDepartment);
                    if (CheckDataObj(objDepartment) == true)
                    {
                        if (lgDepartment.InsertData(objDepartment) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objDepartment);
                    if (CheckDataObj(objDepartment) == true)
                    {
                        if (lgDepartment.UpdatetData(objDepartment) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }
            }
            if (e.Button.Properties.Caption == "Save And New")
            {
                if (iddepartment == null)
                {
                    truyenThamSo(objDepartment);
                    if (CheckDataObj(objDepartment) == true)
                    {
                        if (lgDepartment.InsertData(objDepartment) == true)
                        {
                            this.hinthi();
                            ResetControl();
                         
                            txtDepartment_Code.Focus();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objDepartment);
                    if (CheckDataObj(objDepartment) == true)
                    {
                        if (lgDepartment.UpdatetData(objDepartment) == true)
                        {
                            this.hinthi();
                            ResetControl();
                            iddepartment = null;
                            txtDepartment_Code.Focus();
                        }
                    }
                }
            }
            if (e.Button.Properties.Caption == "Delete")
            {
                XtraMessageBox.Show("Delete");
                if (iddepartment != null)
                {
                   lgDepartment.DeleteData(iddepartment, useraction);
                   
                }
            }
        }
      
        private void frmNhomHang_Action_Load(object sender, EventArgs e)
        {

        }

        public void NhanData(string IDDepartment, string Department_Code, string Department_Name)
        {
            iddepartment = IDDepartment;

            department_code = Department_Code;
            department_name = Department_Name;
            txtDepartment_Code.Text = department_code;
            txtDepartment_Name.Text = department_name;
        }
    }
}