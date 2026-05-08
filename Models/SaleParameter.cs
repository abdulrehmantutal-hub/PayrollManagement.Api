using InvoiceMenagment.Api.Models.InvoiceMenagment.Api.Models;
using Newtonsoft.Json;

namespace InvoiceMenagment.Api.Models
{
    public class SaleParameter : BasicEntity
    {
        public int? SaleId { get; set; }
        public int? ItemId { get; set; }
        public string? Quantity { get; set; }
        public string? Rate { get; set; }
        public string? TradePrice { get; set; }
        public string? Discount { get; set; }
        public string? GrossAmount { get; set; }

        public string? NetAmount { get; set; }

        public Sale Sale { get; set; }
        [JsonIgnore]
        public AccountDetail Item { get; set; }
        public string? DMG { get; set; } // ✅ New column in entity


    }
}
