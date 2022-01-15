using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerObjectData
{
    public class objNote_ExportReturn
    {
        public string ID{ get; set; }
        public string Code { get; set; }
        public string DateAction { get; set; }
        public string Receiver { get; set; }

        public string Delivery_Person { get; set; }
        public string Detail { get; set; }
        public string UserAction { get; set; }
    }
}
