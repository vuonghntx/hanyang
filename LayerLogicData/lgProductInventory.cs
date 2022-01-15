using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgProductInventory
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgProductInventory()
        {
            sv = config.Set();
        }
        public DataTable Show_ListInventoryExport(string date)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_ListInventory";
                string[] thamso = { "@action","@Date" };
                object[] giatri = { "Inventory_ListExport" ,date};
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return data;
        }
        public DataTable Show_ListInventoryImportDepartment(string date)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_ListInventory";
                string[] thamso = { "@action", "@Date" };
                object[] giatri = { "Inventory_ListImportDepartment", date };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return data;
        }
        public void Catulater_Inverntory(string idproduct, string idlot)
        {
            try
            {
                string TenThuTuc = "P_Caculator_Inventory";
                string[] thamso = { "@IDProduct", "@IDLot" };
                object[] giatri = { idproduct, idlot };
                sv.ExcuteProcedureSQL(TenThuTuc, thamso, giatri);
            }
            catch 
            {
            }
        }
        public DataTable Show_InventoryAll(string bedindate, string enddate)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_Inventory";
                string[] thamso = {  "@DateBigin","@DateEnd" };
                object[] giatri = { bedindate , enddate};
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return data;
        }
        public DataTable Show_DetailWarehouseCard(string bedindate, string enddate,string idproduct, string idlot)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_WarehouseCard";
                string[] thamso = { "@DateBegin", "@DateEnd", "@IDProduct", "@IDLot" };
                object[] giatri = { bedindate, enddate, idproduct, idlot };
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
