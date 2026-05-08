using InvoiceMenagment.Api.DTOs;

namespace InvoiceMenagment.Api.Models
{
    public class GeneralLedger : BasicEntity
    {
       public int? FromTypeId { get; set; }
       public  LookUpName FromType { get; set; }
        public string LedgerDate { get; set; }
        public string AutoNumber { get; set; }
        public string RefrenceNumber { get; set; }
        public int RefrenceRelationId { get; set; }
        public IList<GeneralLedgerParameters>? GeneralLadgerParameters { get; set; }         
    }
}


