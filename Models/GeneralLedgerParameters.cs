namespace InvoiceMenagment.Api.Models
{
    public class GeneralLedgerParameters : BasicEntity
    {
        public int GeneralLedgerId { get; set; }
        //public GeneralLedger GeneralLedger { get; set; }
        public string? AccountCode { get; set; }
        public int? AccountRelationId { get; set; }
        public string? Particulars { get; set; }
        public string? DebitAmount { get; set; }
        public string? CreditAmount { get; set; }
        public string? InverseAccountCode { get; set; }
        public int? InverseAccountRelationId { get; set; }

        // ✅ New field to link with BookParameter
        public int? BookParameterId { get; set; }

    }
}
