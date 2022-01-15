using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServicesIT
{
    public class logicDB
    {
        private SqlConnection connnect;

        public logicDB()
        {
            
            connnect = new SqlConnection("Data Source= 172.16.1.66;Initial Catalog= warehouseit;User Id = sa; Password = 123");
            
        }
        // thực hiện câu thủ tục sql insert, update, delete
     
        public int ExcuteStoredProcedure(string Tenthutuc, string[] cacthamso, object[] giatricacthamso)
        {
            try
            {
                connnect.Open();
                SqlCommand cmm = new SqlCommand(Tenthutuc, connnect);
                cmm.Connection = connnect;
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.CommandTimeout = 1800;

                SqlParameter thamso;
                for (int i = 0; i < cacthamso.Length; i++)
                {
                    thamso = new SqlParameter(cacthamso[i], giatricacthamso[i]);
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
        public DataTable ExcuteStoredProcedureselect(string Tenthutuc, string[] cacthamso, object[] giatricacthamso)
        {
            try
            {
                connnect.Open();
                SqlCommand cmm = new SqlCommand(Tenthutuc);
                cmm.Connection = connnect;
                cmm.CommandType = CommandType.StoredProcedure;
                SqlParameter thamso;
                for (int i = 0; i < cacthamso.Length; i++)
                {
                    thamso = new SqlParameter(cacthamso[i], giatricacthamso[i]);
                    cmm.Parameters.Add(thamso);
                }
                SqlDataReader data = cmm.ExecuteReader();
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

        public SqlDataAdapter getDataAdapter(string Tenthutuc, string[] cacthamso, object[] giatricacthamso)
        {
            try
            {
                connnect.Open();
                SqlCommand cmm = new SqlCommand(Tenthutuc);
                cmm.Connection = connnect;
                cmm.CommandType = CommandType.StoredProcedure;
                SqlParameter thamso;
                for (int i = 0; i < cacthamso.Length; i++)
                {
                    thamso = new SqlParameter(cacthamso[i], giatricacthamso[i]);
                    cmm.Parameters.Add(thamso);
                }
                SqlDataAdapter dtAdap = new SqlDataAdapter(cmm);

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