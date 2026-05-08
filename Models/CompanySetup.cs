using System.ComponentModel.DataAnnotations;

namespace InvoiceMenagment.Api.Models
{
    public class CompanySetup : BasicEntity
    {

        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public string? ContactNumber { get; set; }
        public string? WhatsAppNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }  
        public string? LogoUrl { get; set; }
        
    }
}
