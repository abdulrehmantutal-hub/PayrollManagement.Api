namespace InvoiceMenagment.Api.Models
{
    public class PurchaseReturn : BasicEntity
    {
        public string? AutoNumber { get; set; }
        public string? Date { get; set; }
        public int? SupplierId { get; set; }
        public string? VicheleNumber { get; set; }
        public string? PurchaseReturnNumber { get; set; }
        public string? Remarks { get; set; }
        public AccountDetail? Supplier { get; set; }
        public string? PartyName { get; set; }
        public ICollection<PurchaseReturnParameter> PurchaseReturnParameter { get; set; }
    }
}
