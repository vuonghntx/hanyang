using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgNote_ExportAllocation
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgNote_ExportAllocation()
        {
            sv = config.Set();
        }
        public bool InsertData(LayerObjectData.objNote_ExportAllocation obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_ExportAllocation";
                string[] thamso = { "@action", "@ID", "@Code", "@DateAction","@Detail", "@UserAction","@IDDepartment","@Receriver", "@Delivery_Person" };
                object[] giatri = { "Insert", obj.ID, obj.Code, obj.DateAction, obj.Detail, obj.UserAction, obj.IDDepartment, obj.Receriver, obj.Delivery_Persion };
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
        public bool UpdatetData(LayerObjectData.objNote_ExportAllocation obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_ExportAllocation";
                string[] thamso = { "@action", "@ID", "@Code", "@DateAction", "@Detail", "@UserAction", "@IDDepartment", "@Receriver", "@Delivery_Person" };
                object[] giatri = { "Update", obj.ID, obj.Code, obj.DateAction, obj.Detail, obj.UserAction, obj.IDDepartment, obj.Receriver, obj.Delivery_Persion };
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
        public bool DeleteData(string ID, string useraction)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_ExportAllocation";
                string[] thamso = { "@action", "@UserAction" , "@ID" };
                object[] giatri = { "Delete", useraction, ID };
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
                string TenThuTuc = "P_ExportAllocation";
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
        public string GetID(string code)
        {
            string sophieu = null;
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_ExportAllocation";
                string[] thamso = { "@action", "@Code" };
                object[] giatri = { "SelectID", code };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
                sophieu = data.Rows[0][0].ToString();
            }
            catch
            {
                sophieu = null;
            }
            return sophieu;
        }
    }
}
