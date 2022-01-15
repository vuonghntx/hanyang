using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgGantPermission
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgGantPermission()
        {
            sv = config.Set();
        }
        public bool InsertChucNang(string IDUserGr)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_GantPermission";
                string[] thamso = { "@action", "@IDUserGr" };
                object[] giatri = { "Insert", IDUserGr };
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
        public bool UpdateChucNang(string IDUserGr)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_GantPermission";
                string[] thamso = { "@action", "@IDUserGr" };
                object[] giatri = { "Update", IDUserGr };
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
        public void UpdateDSChucNang(DataTable dt, string IDUserGr)
        {
            try
            {
                string TenThuTuc = "P_GantPermission";
                string[] thamso = { "@action", "@IDUserGr" };
                object[] giatri = { "UpdateDS", IDUserGr };
                sv.AutoUpdateDatabase(dt, TenThuTuc, thamso, giatri);
            }
            catch { }
        }
        public DataTable ShowListData(string IDUserGr)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_GantPermission";
                string[] thamso = { "@action", "@IDUserGr" };
                object[] giatri = { "SelectAll", IDUserGr };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return data;
        }
        public DataTable ShowListPermisson()
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_GantPermission";
                string[] thamso = { "@action" };
                object[] giatri = { "LisPermission" };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return data;
        }
        public DataTable ShowListMenu(string IDUserGr)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_GantPermission";
                string[] thamso = { "@action", "@IDUserGr" };
                object[] giatri = { "QuyenMenu", IDUserGr };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return data;
        }
        public DataTable ShowListChucNang(string IDUserGr)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_GantPermission";
                string[] thamso = { "@action", "@IDUserGr" };
                object[] giatri = { "SelectQSD", IDUserGr };
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
