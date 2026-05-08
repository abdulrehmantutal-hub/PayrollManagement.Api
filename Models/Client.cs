using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMenagment.Api.Models
{
    public class Client
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ClientName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
