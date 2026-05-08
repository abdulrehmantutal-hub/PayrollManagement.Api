using System.ComponentModel.DataAnnotations;

namespace InvoiceMenagment.Api.Models
{
    public class LicenseModel
    {
        public string ClientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Hash { get; set; }
    }

}
