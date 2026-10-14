using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RfidConnectRegister.DML
{
    public class WarehouseDto
    {
        public int Id { get; set; }
        public string DestinationCode { get; set; }
        public string DestinationTitle { get; set; }
        public DestinationOperationalType OperationalType { get; set; }
        public DestinationInventoryType InventoryType { get; set; }
        public bool IsDefault { get; set; }
        public bool allowCancel { get; set; }
        public bool allowRePrint { get; set; }
        public bool IsActive { get; set; }
        public string Epc { get; set; }

        


    }
    public enum DestinationOperationalType
    {
        NotSpecified = -1,
        Production,
        Product,
        Material,
        Waste,
        Loading
    }

    public enum DestinationInventoryType
    {
        NotSpecified = -1,
        Virtual,
        Physical
    }


 

}
