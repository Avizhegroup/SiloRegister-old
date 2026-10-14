using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfidConnectRegister.DML
{
    public class Tag
    {
        public string ProductSerial { get; set; }
        public string ProductOldSerial { get; set; }
        public string ProductCode { get; set; }
        public string TagEpc { get; set; }
        public string ProjectCode { get; set; }
        public decimal ProductCount { get; set; }
        public string ProductName { get; set; }
        public int ProductType { get; set; }
        public string NotEnterCount { get; set; }
        public string ProductTypeTitle { get; set; }
        public string ProductStatus { get; set; }

        public string ProductStatusTitle { get; set; }
        public int TagStatus { get; set; }
        public string TagStatusTitle { get; set; }
        public string TagRegisterShamsiUnixDate { get; set; }
        public string TagRegisterUser { get; set; }
        public string TagTreeParentId { get; set; }
        public string TagTreeSecondParentId { get; set; }
        public string TagTreeParentsId { get; set; }
        public string NewProductSerial { get; set; }
        public string ProductProperties { get; set; }
        public Boolean Lock { get; set; }
        public Boolean Freeze { get; set; }
        public Boolean Deactivate { get; set; }
        public int TagInActionId { get; set; }
        public string TagInDestinationId { get; set; }
        public int TagInActionId2 { get; set; }        
        public string TagInDestinationId2 { get; set; }
        public string fld_ProductPropertyAId { get; set; }
        public string fld_ProductPropertyBId { get; set; }
        public string fld_ProductPropertyCId { get; set; }
        public string fld_ProductPropertyATitle { get; set; }
        public string fld_ProductPropertyBTitle { get; set; }
        public string fld_ProductPropertyCTitle { get; set; }
        public string RegCode { get; set; }
        public string ContractStatus { get; set; }
        public string TagZone { get; set; }
        public string ProductUnit { get; set; }
        public DateTime TagRegisterDateTime { get; set; }


        public string FreezeStatusTitle { get; set; }
        public string InspectStatusTitle { get; set; }
        public string ProductValue { get; set; }
        public string ProductPackWeight { get; set; }
        public string ProductPackVolume { get; set; }
        public string ProductCountInPack { get; set; }
        
        public string ProductSize { get; set; }


        public string TagTreeParentSerial { get; set; }
        public string TagTreeParentsEpc { get; set; }


        public string RActionId { get; set; }
        public string RActionDate { get; set; }
        public string RActionTime { get; set; }
 

        public string HActionId { get; set; }
        public string HActionDate { get; set; }
        public string HActionTime { get; set; }
        public string HActionData { get; set; }
        public string HMovementActionCarPlaque { get; set; }
        public string HMovementActionDriverName { get; set; }


    }
}
