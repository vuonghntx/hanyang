using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgListLot
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgListLot()
        {
            sv = config.Set();
        }
        public bool InsertData(LayerObjectData.objListLot obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_ListLot";
                string[] thamso = { "@action", "@IDLot", "@IDProduct", "@DateProduction","@Serial","@Detail", "@UserAction","@LotNumber" };
                object[] giatri = { "Insert", obj.IDLot, obj.IDProduct, obj.DateProduction,obj.Serial, obj.Detail, obj.UserAction,obj.LotNumber };
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
        public bool UpdatetData(LayerObjectData.objListLot obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_ListLot";
                string[] thamso = { "@action", "@IDLot", "@IDProduct", "@DateProduction", "@Serial", "@Detail", "@UserAction", "@LotNumber" };
                object[] giatri = { "Update", obj.IDLot, obj.IDProduct, obj.DateProduction, obj.Serial, obj.Detail, obj.UserAction, obj.LotNumber };
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
        public bool DeleteData(string IDLot, string useraction)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_ListLot";
                string[] thamso = { "@action", "@UserAction" , "@IDLot" };
                object[] giatri = { "Delete", useraction, IDLot };
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
        public DataTable ShowListData(string IDproduct)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_ListLot";
                string[] thamso = { "@action", "@IDProduct" };
                object[] giatri = { "SelectAll" , IDproduct};
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
