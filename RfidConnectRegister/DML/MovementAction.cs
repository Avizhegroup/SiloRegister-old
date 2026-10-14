using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfidConnectRegister.DML
{
    public class MovementAction
    {

    

                 public string MovementActionId { get; set; }
        public string MovementActionUserId { get; set; }
        public string MovementActionDate { get; set; }
        public string MovementActionTime { get; set; }
        public string MovementActionCountTags { get; set; }
        public string MovementActionCarPlaque { get; set; }
        public string MovementActionDriverName { get; set; }
        public string MovementActionDriverMobile { get; set; }
        public string MovementActionData { get; set; }
        public string MovementActionUHFLogIDData { get; set; }
        public string MovementActionDesc { get; set; }
        public string MovementActionDocumentId { get; set; }
    }
}
