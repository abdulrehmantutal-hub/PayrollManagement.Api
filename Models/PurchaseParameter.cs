
using Newtonsoft.Json;

namespace InvoiceMenagment.Api.Models
{
    public class PurchaseParameter : BasicEntity
    {
        public int PurchaseId { get; set; }
        public int? ItemId { get; set; }
        public string? Quantity { get; set; }
        public string? SecondWeight { get; set; }
        public string? FixedKaat { get; set; }
        public string? FirstWeight { get; set; }
        public string? WheatQuantityKaat { get; set; }
        public string? NetWeight { get; set; }
        public string? PurchaseRate { get; set; }
        public string? GrossAmmount { get; set; }
        public string? BrokeryRate { get; set; }
        public string? BrokeryAmount { get; set; }
        public string? MarketFeeRate { get; set; }  
        public string? MarketFeeAmount { get; set; }
        public string? Amount { get; set; }
        public string? FreightAmount { get; set; }
        public string? NetAmount { get; set; }
        public string? Rate { get; set; }
        public string? Bardana { get; set; }

        [JsonIgnore]
        public Purchase Purchase { get; set; }
        public AccountDetail Item { get; set; }
    }
}
