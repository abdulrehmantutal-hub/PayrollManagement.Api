using System.Linq;

namespace InvoiceMenagment.Api.Models
{
    public class StockConfig : BasicEntity
    {
        public int StockConfigMasterId { get; set; } 
        public StockConfigrationMaster? StockConfigMaster { get; set; }

        public int BardanaDescriptionId { get; set; }
        public virtual LookUpName BardanaDescription { get; set; }
        public DateTime? OpeningDate { get; set; }
        public decimal? OpeningQty { get; set; }

        public int? PurchaseBardanaId { get; set; }
        public int? PurchaseFgId { get; set; }
        public int? SaleFgId { get; set; }
        public int? SaleReturnFgId { get; set; }
        public int? SaleBardanaId { get; set; }
        public int? TempId { get; set; }
    }
}
