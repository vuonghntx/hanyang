using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouseIT.ClassReference
{
    public class ConvertDateTime
    {
        public DateTime ConvertStringToDate(string ngay)
        {
            try
            {
                DateTime dt = DateTime.ParseExact(ngay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                return dt;
            }
            catch
            {
                return DateTime.Now;
            }
        }
        public string DateNow()
        {
            DateTime dt = DateTime.Now;
            return dt.ToString("dd/MM/yyyy");

        }
    }
}
