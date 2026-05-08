
using Newtonsoft.Json;

namespace InvoiceMenagment.Api.Models
{
    public class Purchase : BasicEntity
    {
        public string? AutoNumber { get; set; }
        public string? Date { get; set; }
        public string? PurchaseNumber { get; set; }
        public int? PurchaseTypeId { get; set; }
        public LookUpName PurchaseType { get; set; }
        public int? SupplierId { get; set; }
        public string? VicheleNumber { get; set; }
        public string? Remarks { get; set; }
        public string? PaymentDays { get; set; }
        public string? PartyName { get; set; }
        public int? StatusId { get; set; }
        public LookUpName Status { get; set; }


        public AccountDetail Supplier { get; set; }
        [JsonIgnore]
        public ICollection<PurchaseParameter> PurchaseParameters { get; set; }
    }
}
