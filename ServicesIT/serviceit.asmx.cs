using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicesIT
{
    /// <summary>
    /// Summary description for serviceit
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class serviceit : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet GetDataSet(string tenthutuc, string[] thamso, object[] giatri)
        {
            try
            {
                logicDB ac = new logicDB();
                SqlDataAdapter dt = new SqlDataAdapter();
                dt = ac.getDataAdapter(tenthutuc, thamso, giatri);
                DataSet ds = new DataSet();
                dt.Fill(ds);
                return ds;
            }
            catch 
            {
                return null;
            }
        }
        // TRả về dataset

        [WebMethod]
        public int ExcuteProcedureSQL(string tenthutuc, string[] thamso, object[] giatri)
        {
            try
            {
                logicDB ac = new logicDB();
                if (ac.ExcuteStoredProcedure(tenthutuc, thamso, giatri) == 1)
                    return 1;
                else return 7;
            }
            catch //(Exception ex)
            {
                //ILog logger = log4net.LogManager.GetLogger("", tenthutuc);
                //logger.Error(ex);
                ////Helper.LogHelper.Service.Error(ex);
                return 7;
            }
        }
        // Thực thi câu lệnh sql Trả về int
        [WebMethod]
        public void AutoUpdateDatabase(DataTable dt, string procedureName, string[] parameter, object[] value)
        {
            try
            {
                logicDB ac = new logicDB();
                SqlDataAdapter da = new SqlDataAdapter();
                da = ac.getDataAdapter(procedureName, parameter, value);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(dt);
            }
            catch //(Exception ex)
            {
              
            }
        }

       
    }
}
