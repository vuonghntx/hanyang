using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgProduct
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgProduct()
        {
            sv = config.Set();
        }

        public bool InsertData(LayerObjectData.objProduct obj)
        {
            bool kt = false;
            try
            {

                string TenThuTuc = "P_Category_Product";
                string[] thamso = { "@action", "@IDProduct", "@Product_Code", "@Product_Name", "@Product_Unit", "@Product_Manufacturer", "@Product_Country", "@Product_Detail", "@IDProductGr", "@UserAction","@Product_Price" };
                object[] giatri = { "Insert", obj.IDProduct,obj.Product_Code,obj.Product_Name,obj.Product_Unit,obj.Product_Manufacturer, obj.Product_Country,obj.Product_Detail,obj.IDProductGr,obj.UserAction, obj.Product_Price };
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
        public bool UpdatetData(LayerObjectData.objProduct obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Product";
                string[] thamso = { "@action", "@IDProduct", "@Product_Code", "@Product_Name", "@Product_Unit", "@Product_Manufacturer", "@Product_Country", "@Product_Detail", "@IDProductGr", "@UserAction", "@Product_Price" };
                object[] giatri = { "Update", obj.IDProduct, obj.Product_Code, obj.Product_Name, obj.Product_Unit, obj.Product_Manufacturer, obj.Product_Country, obj.Product_Detail, obj.IDProductGr, obj.UserAction, obj.Product_Price };
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
        public bool DeleteData(string IDProduct,string useraction)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Product";
                string[] thamso = { "@action", "@UserAction" , "@IDProduct" };
                object[] giatri = { "Delete", useraction, IDProduct };
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
                string TenThuTuc = "P_Category_Product";
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
