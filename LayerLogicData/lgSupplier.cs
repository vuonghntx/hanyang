using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgSupplier
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgSupplier()
        {
            sv = config.Set();
        }
        public bool InsertData(LayerObjectData.objSupplier obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Supplier";
                string[] thamso = { "@action", "@IDSupplier", "@Supplier_Code", "@Supplier_Name","@Supplier_Address", "@Supplier_Phone","@Supplier_Email", "@UserAction" };
                object[] giatri = { "Insert", obj.IDSupplier, obj.Supplier_Code, obj.Supplier_Name, obj.Supplier_Addresss, obj.Supplier_Phone, obj.Supplier_Email, obj.UserAction };
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
        public bool UpdatetData(LayerObjectData.objSupplier obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Supplier";
                string[] thamso = { "@action", "@IDSupplier", "@Supplier_Code", "@Supplier_Name", "@Supplier_Address", "@Supplier_Phone", "@Supplier_Email", "@UserAction" };
                object[] giatri = { "Update", obj.IDSupplier, obj.Supplier_Code, obj.Supplier_Name, obj.Supplier_Addresss, obj.Supplier_Phone, obj.Supplier_Email, obj.UserAction };
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
        public bool DeleteData(string IDSupplier, string useraction)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Supplier";
                string[] thamso = { "@action", "@UserAction" , "@IDSupplier" };
                object[] giatri = { "Delete", useraction, IDSupplier };
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
                string TenThuTuc = "P_Category_Supplier";
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
