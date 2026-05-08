using InvoiceMenagment.Api.DTOs.Response;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMenagment.Api.Models
{
    public class StockAdjustment : BasicEntity
    {
        public string? AutoNumber { get; set; }

        [Column("StockAdjustmentDate")]
        public string? StockAdjustmentDate { get; set; }

        [Column("StockAdjustmentLocationId")]
        public int? StockAdjustmentLocationId { get; set; }

        [ForeignKey("StockAdjustmentLocationId")]
        public virtual LookUpName? StockLocation { get; set; }

        public string? Remarks { get; set; }

        public virtual ICollection<StockAdjustmentParameter> Details { get; set; }
            = new List<StockAdjustmentParameter>();
    }
}
