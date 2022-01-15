using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgFindProduct
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgFindProduct()
        {
            sv = config.Set();
        }
        public DataTable ShowListProduct()
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_ShowListProduct";
                string[] thamso = { "@action" };
                object[] giatri = { "SelectListProduct" };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return data;
        }
        public DataTable ShowListProductExport(string date)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_ListInventory";
                string[] thamso = { "@action", "@Date" };
                object[] giatri = { "Inventory_ListExport", date };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return data;
        }
        //Inventory_ListImportDepartment
        public DataTable ShowListProductImportDepartment(string date, string idDepartment)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_ListInventory";
                string[] thamso = { "@action", "@Date","@DuLieu" };
                object[] giatri = { "Inventory_ListImportDepartment", date, idDepartment };
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
