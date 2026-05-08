using System.ComponentModel.DataAnnotations;

namespace InvoiceMenagment.Api.Models
{
    public class Supplier : BasicEntity
    {
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? NationalIdentityCardNumber { get; set; }
        public string? NationalTaxNumber { get; set; }
        public string? FaxNumber { get; set; }
        public string? SalesTaxRegistrationNumber { get; set; }
        public int? AccountDetailId { get; set; }
        public AccountDetail accountDetail { get; set; }
    }
}
