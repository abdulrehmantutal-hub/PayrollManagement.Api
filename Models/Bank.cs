using MimeKit.Encodings;

namespace InvoiceMenagment.Api.Models
{
    public class Bank : BasicEntity
    {      
        public int? SubGroupId { get; set; }
        public AccountSubGroup SubGroup { get; set; }
       public string? BankName { get; set; }
       public string? BranchName { get; set; }
       public string? BranchCode { get; set; }
       public string? AccountTitle { get; set; }
       public string? AccountNumber { get; set; }
       public string? IBAN { get; set; }
       public string? SwiftCode { get; set; }
       public string? Currency { get; set; }
       public string? ContactNumber { get; set; }
       public string? Email { get; set; }
       public string? Address { get; set; }
       public string? Logo { get; set; }


    }
}
