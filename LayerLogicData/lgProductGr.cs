using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgProductGr
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgProductGr()
        {
            sv = config.Set();
        }
        public bool InsertData(LayerObjectData.objProductGr obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_ProductGr";
                string[] thamso = { "@action", "@IDProductGr", "@ProductGr_Code", "@ProductGr_Name", "@UserAction" };
                object[] giatri = { "Insert", obj.IDProductGr,obj.ProductGr_Code,obj.ProductGr_Name,obj.UserAction };
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
        public bool UpdatetData(LayerObjectData.objProductGr obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_ProductGr";
                string[] thamso = { "@action", "@IDProductGr", "@ProductGr_Code", "@ProductGr_Name", "@UserAction" };
                object[] giatri = { "Update", obj.IDProductGr, obj.ProductGr_Code, obj.ProductGr_Name, obj.UserAction };
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
        public bool DeleteData(string IDProductGr, string useraction)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_ProductGr";
                string[] thamso = { "@action", "@UserAction" , "@IDProductGr" };
                object[] giatri = { "Delete", useraction, IDProductGr };
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
                string TenThuTuc = "P_Category_ProductGr";
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
