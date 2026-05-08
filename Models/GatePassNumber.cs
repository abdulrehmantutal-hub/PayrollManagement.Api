using System.ComponentModel.DataAnnotations;

namespace InvoiceMenagment.Api.Models
{
    public class GatePassNumber : BasicEntity
    {
        public string? AutoNumber { get; set; }
        public DateTime? EffectiveFromDate { get; set; }
        public bool? IsUsed { get; set; }

    }
}
