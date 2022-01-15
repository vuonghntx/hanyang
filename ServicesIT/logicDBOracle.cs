using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace ServicesIT
{
    public class logicDBOracle
    {
        [Obsolete]
        private OracleConnection connnect;

        [Obsolete]
        public logicDBOracle()
        {
         
            string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = 107.11.192.41)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = HYVMES)));" + "User Id= mesadmin;Password=mesadmin;";
            connnect = new OracleConnection(oradb);            
        }

        // thực hiện câu thủ tục sql insert, update, delete
        [Obsolete]
        public int ExcuteStoredProcedure(string Tenthutuc, string[] cacthamso, object[] giatricacthamso)
        {
            try
            {
                connnect.Open();
                OracleCommand cmm = new OracleCommand(Tenthutuc, connnect);
                cmm.Connection = connnect;
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.CommandTimeout = 1800;

                OracleParameter thamso;
                for (int i = 0; i < cacthamso.Length; i++)
                {
                    thamso = new OracleParameter(cacthamso[i], giatricacthamso[i]);
                    cmm.Parameters.Add(thamso);
                }
                return cmm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connnect.Close();
            }
        }

        [Obsolete]
        public DataTable ExcuteStoredProcedureselect(string Tenthutuc, string[] cacthamso, object[] giatricacthamso)
        {
            try
            {
                connnect.Open();
                OracleCommand cmm = new OracleCommand(Tenthutuc);
                cmm.Connection = connnect;
                cmm.CommandType = CommandType.StoredProcedure;
                OracleParameter thamso;
                for (int i = 0; i < cacthamso.Length; i++)
                {
                    thamso = new OracleParameter(cacthamso[i], giatricacthamso[i]);
                    cmm.Parameters.Add(thamso);
                }
                OracleDataReader data = cmm.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(data);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connnect.Close();
            }
        }

        [Obsolete]
        public OracleDataAdapter getDataAdapter(string Tenthutuc, string[] cacthamso, object[] giatricacthamso)
        {
            try
            {
                connnect.Open();
                OracleCommand cmm = new OracleCommand(Tenthutuc);
                cmm.Connection = connnect;
                cmm.CommandType = CommandType.StoredProcedure;
                OracleParameter thamso;
                for (int i = 0; i < cacthamso.Length; i++)
                {
                    thamso = new OracleParameter(cacthamso[i], giatricacthamso[i]);
                    cmm.Parameters.Add(thamso);
                }
                var dtAdap = new OracleDataAdapter(cmm);

                return dtAdap;
            }
            catch (Exception ex)
            { 
                throw ex;
            }
            finally
            {
                connnect.Close();
            }

        }
    }
}