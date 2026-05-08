using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMenagment.Api.Models
{
    public class LicenseLog
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ClientId { get; set; }
        public Client? Client { get; set; }
        public DateTime? LicenseIssuedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LicenseExpiredAt { get; set; }
        public string? Note { get; set; }

    }
}
