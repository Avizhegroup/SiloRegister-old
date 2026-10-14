using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfidConnectRegister.DML
{
    public class Zones
    {
        public string ZoneCode { get; set; }
        public string ZoneTitle { get; set; }
        public string ZoneCapacity { get; set; }
        public string ZoneParentCode { get; set; }        
        public string ZoneStoreCode { get; set; }
        public string ZoneParentLayer { get; set; }

        public string MinZoneCapacity { get; set; }
        public string MaxZoneCapacity { get; set; }
    }
}
