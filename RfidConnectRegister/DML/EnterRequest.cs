using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfidConnectRegister.DML
{
    public class EnterRequest
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        
        public string TechnicalCode { get; set; }
        public string Shift { get; set; }

        public string ProductSerial { get; set; }


    }
}
