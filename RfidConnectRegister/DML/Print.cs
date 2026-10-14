using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RfidConnectRegister.DML
{
    public class Print
    {
        public int Id { get; set; }
        public string ProductSerial { get; set; }
        public string ProductOldSerial { get; set; }
        public string ProductTitle { get; set; }
        public string ProductENTitle { get; set; }
        public string ProductTechnicalData { get; set; }

        public string RegisterDate { get; set; }
        public string RegisterUser { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductCount { get; set; }
        public string TagEpc { get; set; }
        public int PrintFlag { get; set; }
        public int RegisterFlag { get; set; }
        public int RegisterType { get; set; }
        public string InputFileName { get; set; }
        public string PrintType { get; set; }
        public string PrintUser { get; set; }
        public string ErrorTime { get; set; }
        public string ErrorDesc { get; set; }
        public int PrintActionId { get; set; }
        public DateTime PrintActionDateTime { get; set; }
        public string ProductUnit { get; set; }
        public decimal ProductItemCount { get; set; }
        public decimal ProductCountInPack { get; set; }
        public string ProductSize { get; set; }
        public string ProductSizeTitle { get; set; }
        public string ProductRegCode { get; set; }
        public decimal ProductWeight { get; set; }
        public decimal ProductVolume { get; set; }
        public string ProductStatus { get; set; }
        public string ProductBrand { get; set; }
        public string ProductGroup { get; set; }
       
        public string ProductBrandTitle { get; set; }
        public string ProductGroupTitle { get; set; }

        public string ProjectCode { get; set; }
        public string ProductStatusTitle { get; set; }
        public string ProductProductionShift { get; set; }

        public string ProductProductionShiftTitle { get; set; }
        public string ProductProductionLine { get; set; }

        public string ProductProductionLineTitle { get; set; }
        public string ProductContractType { get; set; }
        public string ProductType { get; set; }
        public string DocumentId { get; set; }
        public string ProductTypeTitle { get; set; }
        public string WareHouseCode { get; set; }
        public string ProductProperties { get; set; }

        

    }
}
