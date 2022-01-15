using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgEmployee
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgEmployee()
        {
            sv = config.Set();
        }
        public bool InsertData(LayerObjectData.objEmployee obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Employee";
                string[] thamso = { "@action", "@IDEmployee", "@Employee_Code", "@Employee_Name","@IDDepartment", "@UserAction" };
                object[] giatri = { "Insert", obj.IDEmployee, obj.Employee_Code, obj.Employee_Name, obj.IDDepartment, obj.UserAction };
                int a = sv.ExcuteProcedureSQL(TenThuTuc, thamso, giatri);
                if (a == 1)
                    kt = true;
                else kt = false;
            }
            catch
            {
                kt = false;
            }
            return kt;
        }
        public bool UpdatetData(LayerObjectData.objEmployee obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Employee";
                string[] thamso = { "@action", "@IDEmployee", "@Employee_Code", "@Employee_Name", "@IDDepartment", "@UserAction" };
                object[] giatri = { "Update", obj.IDEmployee, obj.Employee_Code, obj.Employee_Name, obj.IDDepartment, obj.UserAction };
                int a = sv.ExcuteProcedureSQL(TenThuTuc, thamso, giatri);
                if (a == 1)
                    kt = true;
                else kt = false;
            }
            catch
            {
                kt = false;
            }
            return kt;
        }
        public bool DeleteData(string IDEmployee, string useraction)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Employee";
                string[] thamso = { "@action", "@UserAction" , "@IDEmployee" };
                object[] giatri = { "Delete", useraction, IDEmployee };
                int a = sv.ExcuteProcedureSQL(TenThuTuc, thamso, giatri);
                if (a == 1)
                    kt = true;
                else kt = false;
            }
            catch
            {
                kt = false;
            }
            return kt;
        }
        public DataTable ShowListData()
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_Category_Employee";
                string[] thamso = { "@action" };
                object[] giatri = { "SelectAll" };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return data;
        }
    }
}
