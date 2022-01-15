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
    public partial class frmEmployee_Action : DevExpress.XtraEditors.XtraForm
    {
        saveConfigRegedit saveConfig = new saveConfigRegedit();
        LayerLogicData.lgDepartment lgDepartment = new LayerLogicData.lgDepartment();

        public frmEmployee_Action()
        {
            InitializeComponent();
            useraction = saveConfig.UserName;
        }
        string useraction;
        string iddepartment, employee_code, employee_name, idemployee;
        
        public delegate void HienThiThongTin();
        public HienThiThongTin hinthi;

        LayerLogicData.lgEmployee lgEmployee = new LayerLogicData.lgEmployee();
        LayerObjectData.objEmployee objEmployee = new LayerObjectData.objEmployee();
        public void truyenThamSo(LayerObjectData.objEmployee obj)
        {
            obj.IDEmployee = idemployee;
            obj.Employee_Code = txtDepartment_Code.Text;
            obj.Employee_Name = txtDepartment_Name.Text;
            obj.IDDepartment = iddepartment;
            obj.UserAction = useraction;
        }
        public void ResetControl()
        {
            txtDepartment_Code.Text = "";
            txtDepartment_Name.Text = "";
            txtDepartment_Code.Focus();
        }
      //  string ThongBao;
        public bool CheckDataObj(LayerObjectData.objEmployee obj)
        {
            if (obj.Employee_Code == "")
            {
                XtraMessageBox.Show("Please enter your Employee Code", "Notification!");
                txtDepartment_Code.Focus();
                return false;
            }
            if (obj.Employee_Name == "")
            {
                XtraMessageBox.Show("Please enter your Employee Name", "Notification!");
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
                    truyenThamSo(objEmployee);
                    if (CheckDataObj(objEmployee) == true)
                    {
                        if (lgEmployee.InsertData(objEmployee) == true)
                        {
                            this.hinthi();
                            this.Close();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objEmployee);
                    if (CheckDataObj(objEmployee) == true)
                    {
                        if (lgEmployee.UpdatetData(objEmployee) == true)
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
                    truyenThamSo(objEmployee);
                    if (CheckDataObj(objEmployee) == true)
                    {
                        if (lgEmployee.InsertData(objEmployee) == true)
                        {
                            this.hinthi();
                            ResetControl();
                         
                            txtDepartment_Code.Focus();
                        }
                    }
                }
                else
                {
                    truyenThamSo(objEmployee);
                    if (CheckDataObj(objEmployee) == true)
                    {
                        if (lgEmployee.UpdatetData(objEmployee) == true)
                        {
                            this.hinthi();
                            ResetControl();
                            iddepartment = null;
                            txtDepartment_Code.Focus();
                        }
                    }
                }
            }
           
        }
        public void ShowDepartment()
        {
            gridDepartment.Properties.DataSource = lgDepartment.ShowListData();
        }
      
        private void frmNhomHang_Action_Load(object sender, EventArgs e)
        {
            ShowDepartment();
        }

        public void NhanData(string IDEmployee, string Employee_Code, string Employee_Name, string IDDepartment)
        {
            iddepartment = IDDepartment;
            idemployee = IDEmployee;
            employee_code = Employee_Code;
            employee_name = Employee_Name;
            txtDepartment_Code.Text = employee_code;
            txtDepartment_Name.Text = employee_name;
        }
    }
}