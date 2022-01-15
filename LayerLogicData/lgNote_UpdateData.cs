using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class lgNote_UpdateData
    {
        configServices config = new configServices();
        ServiceReference.serviceitSoapClient sv;
        public lgNote_UpdateData()
        {
            sv = config.Set();
        }
        public void NoteDataDetail(DataTable dt, string thutuc, string ID)
        {
            try
            {                
                string[] thamso = { "@ID"};
                object[] giatri = { ID};
                sv.AutoUpdateDatabase(dt,thutuc, thamso, giatri);
            }
            catch
            {
            }
        }
    }
}
