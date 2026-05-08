using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace InvoiceMenagment.Api.Models
{
    public class GatePassAudit
    {
        [Key]
        public long id { get; set; }
        public string serial_number { get; set; } = string.Empty;
        public DateTime created_at { get; set; }
        public string? payload { get; set; }
        public bool is_confirm { get; set; } = false;

        [NotMapped]
        public JsonDocument? PayloadJson
        {
            get => string.IsNullOrWhiteSpace(payload) ? null : JsonDocument.Parse(payload);
            set => payload = value?.RootElement.ToString();
        }
    }
}
