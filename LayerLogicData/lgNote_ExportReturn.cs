using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgNote_ExportReturn
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgNote_ExportReturn()
        {
            sv = config.Set();
        }
        public bool InsertData(LayerObjectData.objNote_ExportReturn obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_ExportReturn";
                string[] thamso = { "@action", "@ID", "@Code", "@DateAction","@Detail", "@UserAction", "@Receiver", "@Delivery_Person" };
                object[] giatri = { "Insert", obj.ID, obj.Code, obj.DateAction, obj.Detail, obj.UserAction, obj.Receiver, obj.Delivery_Person };
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
        public bool UpdatetData(LayerObjectData.objNote_ExportReturn obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_ExportReturn";
                string[] thamso = { "@action", "@ID", "@Code", "@DateAction", "@Detail", "@UserAction" , "@Receiver", "@Delivery_Person" };
                object[] giatri = { "Update", obj.ID, obj.Code, obj.DateAction, obj.Detail, obj.UserAction , obj.Receiver, obj.Delivery_Person};
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
                string TenThuTuc = "P_ExportReturn";
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
                string TenThuTuc = "P_ExportReturn";
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
                string TenThuTuc = "P_ExportReturn";
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
