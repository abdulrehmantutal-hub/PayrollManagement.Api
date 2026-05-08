using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMenagment.Api.Models
{
    public class Cheque : BasicEntity
    {
        public string? AutoNumber { get; set; }
        public string? AutoNumber2 { get; set; }
        public string? ReceivingDate { get; set; }
        public int? CustomerId { get; set; }
        public AccountDetail customer { get; set; }
        public int? BankId { get; set; }
        public LookUpName bank { get; set; }
        public string? ChequeNumber { get; set; }
        public string? ChequeDate { get; set; }
        public string? Amount { get; set; }
        public int? StatusId { get; set; }
        public LookUpName status { get; set; }
        public bool IsGLPosted { get; set; } = false;
        public string? PresentedDate { get; set; }
        public string? ClearingDate { get; set; }

        public string? BouncedDate { get; set; }

        //public int? BankAccountDetailId { get; set; }
        //public AccountDetail bankAccount { get; set; }
        public int? BankAccountDetailId { get; set; }
        [ForeignKey("BankAccountDetailId")]
        public AccountDetail? bankAccountDetails { get; set; }


    }
}
