using InvoiceMenagment.Api.DTOs.Response;

namespace InvoiceMenagment.Api.Models
{
    public class Stock : BasicEntity
    {
        public string? StockDate { get; set; }   // ✅ string banaya
        public int? StatusId { get; set; }
        public virtual LookUpName? Status { get; set; }
        public int? StockLocationId { get; set; }
        public virtual LookUpName? StockLocation { get; set; }
        public string? Remarks { get; set; }
        public string? AutoNumber { get; set; }
        public string? Test { get; set; }

        public virtual ICollection<StockParameters> Details { get; set; } = new List<StockParameters>();
    }
}
