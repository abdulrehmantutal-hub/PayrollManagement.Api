using System.ComponentModel.DataAnnotations;

namespace InvoiceMenagment.Api.Models
{
    public class Customer : BasicEntity
    {

        public string? Name { get; set; }
        public string? ContactNumber { get; set; }
        public string? WhatsAppNumber { get; set; }
        public string? PhoneNumber { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? CNICNumber { get; set; }
        public string? Messers { get; set; }
        public string? NTNNumber { get; set; }
        public string? STRNNumber { get; set; }
        public int? AccountDetailId { get; set; }
        public int? BookerId { get; set; }
        public string? BookerName { get; set; }
        public AccountDetail accountDetail { get; set; }

    }
}
