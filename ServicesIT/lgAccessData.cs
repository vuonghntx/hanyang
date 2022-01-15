using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace ServicesIT
{
    public class lgAccessData
    {
        [Obsolete]
        public DataSet GetDataSet(string tenthutuc, string[] thamso, object[] giatri)
        {
            try
            {
                logicDBOracle ac = new logicDBOracle();
                OracleDataAdapter dt = new OracleDataAdapter();
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
        [Obsolete]
        public int ExcuteProcedureSQL(string tenthutuc, string[] thamso, object[] giatri)
        {
            try
            {
                logicDBOracle ac = new logicDBOracle();
                if (ac.ExcuteStoredProcedure(tenthutuc, thamso, giatri) == 1)
                    return 1;
                else return 7;
            }
            catch 
            {
                return 7;
            }
        }

        // Thực thi câu lệnh sql Trả về int

        [Obsolete]
        public void AutoUpdateDatabase(DataTable dt, string procedureName, string[] parameter, object[] value)
        {
            try
            {
                logicDBOracle ac = new logicDBOracle();
                OracleDataAdapter da = new OracleDataAdapter();
                da = ac.getDataAdapter(procedureName, parameter, value);
                OracleCommandBuilder cb = new OracleCommandBuilder(da);
                da.Update(dt);
            }
            catch //(Exception ex)
            {

            }
        }

    }
}