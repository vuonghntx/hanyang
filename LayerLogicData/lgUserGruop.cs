using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgUserGruop
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgUserGruop()
        {
            sv = config.Set();
        }
        public bool InsertData(LayerObjectData.objUserGroup obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_UserGroup";
                string[] thamso = { "@action", "@IDUserGr", "@UserGr_Code", "@UserGr_Name",  "@UserAction" };
                object[] giatri = { "Insert", obj.IDUserGr, obj.UserGr_Code, obj.UserGr_Name, obj.UserAction };
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
        public bool UpdatetData(LayerObjectData.objUserGroup obj)
        {
            bool kt = false;
            try
            {

                string TenThuTuc = "P_UserGroup";
                string[] thamso = { "@action", "@IDUserGr", "@UserGr_Code", "@UserGr_Name", "@UserAction" };
                object[] giatri = { "Update", obj.IDUserGr, obj.UserGr_Code, obj.UserGr_Name, obj.UserAction };
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
        public bool DeleteData(string IDUserGr, string user)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_UserGroup";
                string[] thamso = { "@action", "@IDUserGr", "@UserAction" };
                object[] giatri = { "Delete", IDUserGr, user };
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
                string TenThuTuc = "P_UserGroup";
                string[] thamso = { "@action"  };
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
        public DataTable ShowRowData(string IDUserGr)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_UserGroup";
                string[] thamso = { "@action", "@IDUserGr" };
                object[] giatri = { "SelectRow", IDUserGr };
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
