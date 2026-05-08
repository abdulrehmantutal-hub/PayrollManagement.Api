using Newtonsoft.Json;

namespace InvoiceMenagment.Api.Models
{
    public class PurchaseReturnParameter : BasicEntity
    {
        public int PurchaseReturnId { get; set; }
        [JsonIgnore]
        public PurchaseReturn PurchaseReturn { get; set; }
        public int? ItemId { get; set; }
        public AccountDetail Item { get; set; }
        public string? Quantity { get; set; }
        public string? Rate { get; set; }
        public string? ManualRate { get; set; }
        public string? GrossAmount { get; set; }
        public string? NetAmount { get; set; }
        public string? AmountDiscount { get; set; }
        public string? PercentageDiscount { get; set; }
        public bool? IsScheme { get; set; }
        public string? SaleTaxAmount { get; set; }
        public string? AdvanceTaxAmount { get; set; }
        public string? AdditionalTaxAmount { get; set; }
        public int? PurchaseReturnTypeId { get; set; }

        //[JsonIgnore]
        //public LookUpName? PurchaseReturnType { get; set; }




    }
}
