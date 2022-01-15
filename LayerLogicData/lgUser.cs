using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgUser
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgUser()
        {
            sv = config.Set();
        }
        public bool InsertData(LayerObjectData.objUser obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_User";
                string[] thamso = { "@action", "@UserName", "@Password", "@Fullname", "@IsRoot", "@UserAction", "@IDUserGr" };
                object[] giatri = { "Insert", obj.Username, obj.Password, obj.Fullname,  obj.IsRoot, obj.UserAction, obj.IDUserGr };
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
        // changeFullName
        public bool ChangeFullName(string FullName, string UserID)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_User";
                string[] thamso = { "@action", "@Fullname", "@UserID" };
                object[] giatri = { "changeFullName", FullName, UserID };
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
        public bool ResetPass(string UserID, string password)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_User";
                string[] thamso = { "@action", "@UserID", "@Password" };
                object[] giatri = { "ResetPass", UserID, password };
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
        public bool changepermissin(string userid, string IDUserGr)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_User";
                string[] thamso = { "@action", "@UserID", "@IDUserGr" };
                object[] giatri = { "ChangePermission", userid, IDUserGr };
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
        public bool IsLock(string userid, string islock)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_User";
                string[] thamso = { "@action", "@UserID", "@IsLock" };
                object[] giatri = { "IsLock", userid, islock };
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
        public bool ChangePass(LayerObjectData.objUser obj)
        {
            bool kt = false;
            try
            {
                string TenThuTuc = "P_User";
                string[] thamso = { "@action", "@UserID", "@Password" };
                object[] giatri = { "ChangePass", obj.UserID, obj.Password };
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
                string TenThuTuc = "P_User";
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
        public bool CheckChangePass(string UserName, string Pass)
        {
            bool kt = false;
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_User";
                string[] thamso = { "@action", "@UserName", "@Password" };
                object[] giatri = { "CheckChangePass",  UserName, Pass };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];

                if (data.Rows.Count > 0)
                    kt = true;
                else kt = false;
            }
            catch
            {
                kt = false;
            }
            return kt;
        }
        //LayLaiMK
        public bool ResetMatKhau( string Pass, string UserID)
        {
            bool kt = false;
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_User";
                string[] thamso = { "@action",  "@Password" , "@UserID" };
                object[] giatri = { "ResetPass",  Pass, UserID };
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
        //public bool ResetMatKhauDMUser(string congtyid, string Pass, string showpass, string username)
        //{
        //    bool kt = false;
        //    DataTable data = new DataTable();
        //    try
        //    {
        //        string TenThuTuc = "P_DMUser";
        //        string[] thamso = { "@action", "@CongTyID", "@MatKhau", "@TenDangNhap", "@ShowMatKhau" };
        //        object[] giatri = { "ChangePassReset", congtyid, Pass, username, showpass };
        //        int a = sv.ExcuteProcedureSQL(TenThuTuc, thamso, giatri);
        //        if (a == 1)
        //            kt = true;
        //        else kt = false;
        //    }
        //    catch
        //    {
        //        kt = false;
        //    }
        //    return kt;
        //}
       
        public bool CheckLogIn( string Username, string Password)
        {
            bool kt = false;
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_User";
                string[] thamso = { "@action", "@UserName", "@Password" };
                object[] giatri = { "CheckLogin", Username, Password };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
                if (data.Rows.Count != 1)
                    kt = false;
                else kt = true;
            }
            catch
            {
                kt = false;
            }
            return kt;
        }
      
        public DataTable GetInforLogin( string Username, string Password)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_User";
                string[] thamso = { "@action", "@UserName", "@Password" };
                object[] giatri = { "CheckLogin", Username, Password };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch
            {
                data = null;
            }
            return data;
        }
       
        public DataTable GetPermissionAction(string IDUserGr, string Permission_name)
        {
            DataTable data = new DataTable();
            try
            {
                string TenThuTuc = "P_User";
                string[] thamso = { "@action", "@Permission_name", "@IDUserGr" };
                object[] giatri = { "GetPermissionAciton", Permission_name, IDUserGr };
                DataSet ds = sv.GetDataSet(TenThuTuc, thamso, giatri);
                data = ds.Tables[0];
            }
            catch
            {
                data = null;
            }
            return data;
        }
    }
}
