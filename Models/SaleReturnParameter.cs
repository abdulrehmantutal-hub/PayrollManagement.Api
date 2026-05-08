using Newtonsoft.Json;

namespace InvoiceMenagment.Api.Models
{
    public class SaleReturnParameter : BasicEntity
    {
        public int? SaleReturnId { get; set; }
        public int? ReturnTypeId { get; set; }
        public LookUpName ReturnType { get; set; }

        public int? ItemId { get; set; }
        public string? Quantity { get; set; }
        public string? Rate { get; set; }
        public string? Amount { get; set; }
        public AccountDetail Item { get; set; }
        public SaleReturn SaleReturn { get; set; }
 
    }
}
