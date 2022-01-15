using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgDepartment
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgDepartment()
        {
            sv = config.Set();
        }
        public bool InsertData(LayerObjectData.objDepartment obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Department";
                string[] thamso = { "@action", "@IDDepartment", "@Department_Code", "@Department_Name", "@UserAction" };
                object[] giatri = { "Insert", obj.IDDepartment, obj.Department_Code, obj.Department_Name, obj.UserAction };
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
        public bool UpdatetData(LayerObjectData.objDepartment obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Department";
                string[] thamso = { "@action", "@IDDepartment", "@Department_Code", "@Department_Name", "@UserAction" };
                object[] giatri = { "Update", obj.IDDepartment, obj.Department_Code, obj.Department_Name, obj.UserAction };
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
        public bool DeleteData(string IDDepartment, string useraction)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Department";
                string[] thamso = { "@action", "@UserAction" , "@IDDepartment" };
                object[] giatri = { "Delete", useraction, IDDepartment };
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
                string TenThuTuc = "P_Category_Department";
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
