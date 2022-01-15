using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgNote_Detail
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgNote_Detail()
        {
            sv = config.Set();
        }
        public DataTable Show_Receipt_New(string @ID)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_ShowDataInListNote";
                string[] thamso = { "@action", "@ID" };
                object[] giatri = { "Note_Receipt", @ID };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return data;
        }
        public DataTable Show_Receipt_Return(string @ID)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_ShowDataInListNote";
                string[] thamso = { "@action", "@ID" };
                object[] giatri = { "Note_Receipt_Return", @ID };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return data;
        }
        public DataTable Show_ExportAllocation(string @ID)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_ShowDataInListNote";
                string[] thamso = { "@action", "@ID" };
                object[] giatri = { "Note_ExportAllocation", @ID };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return data;
        }
        public DataTable Show_ExportReturn(string @ID)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_ShowDataInListNote";
                string[] thamso = { "@action", "@ID" };
                object[] giatri = { "Note_ExportReturn", @ID };
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
