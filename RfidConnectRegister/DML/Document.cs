using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfidConnectRegister.DML
{
    public class DocumentHeader
    {
        public int Id { get; set; }

        public string Key { get; set; }

        public string UserId { get; set; }
        //  public User User { get; set; }

        public ImportType ImportType { get; set; }

        public string FileName { get; set; }

        public int DocumentType { get; set; }

        public DateTime ImportDateTime { get; set; }

        public string Description { get; set; }

        public int Status { get; set; }

        public string HeaderData { get; set; }

        public ICollection<DocumentItem> DocumentItems { get; set; }
    }

    public class DocumentItem
    {
        public int Id { get; set; }

        public string Key { get; set; }

        public int DocumentType { get; set; }

     

        public string ProductCode { get; set; }

        public string ProductTitle { get; set; }

        public int Count { get; set; }
        public int Remain { get; set; }

        public string ProductUnit { get; set; }

        public string ItemData { get; set; }

        public string StatusDesc { get; set; }
    }

    public enum ImportType
    {
        Excel,
        Api,
        Manual,
        Other = 1234
    }
    public class GetAllAggDocDto
    {
        public string DocumentKey { get; set; }
        public string DocumentType { get; set; }
        public DateTime? ImportDateTime { get; set; }
        public int ItemCount { get; set; }
        public decimal ItemSum { get; set; }
        public string DocumentData { get; set; }
    }
}
