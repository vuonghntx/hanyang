using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgDepot
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgDepot()
        {
            sv = config.Set();
        }
        public bool InsertData(LayerObjectData.objDepot obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Depot";
                string[] thamso = { "@action", "@IDDepot", "@Depot_Code", "@Depot_Name", "@UserAction" };
                object[] giatri = { "Insert", obj.IDDepot, obj.Depot_Code, obj.Depot_Name, obj.UserAction };
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
        public bool UpdatetData(LayerObjectData.objDepot obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Depot";
                string[] thamso = { "@action", "@IDDepot", "@Depot_Code", "@Depot_Name", "@UserAction" };
                object[] giatri = { "Update", obj.IDDepot, obj.Depot_Code, obj.Depot_Name, obj.UserAction };
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
        public bool DeleteData(string IDDepot, string useraction)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_Category_Depot";
                string[] thamso = { "@action", "@UserAction" , "@IDDepot" };
                object[] giatri = { "Delete", useraction, IDDepot };
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
                string TenThuTuc = "P_Category_Depot";
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
