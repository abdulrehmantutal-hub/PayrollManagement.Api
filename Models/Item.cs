namespace InvoiceMenagment.Api.Models
{
    public class Item : BasicEntity
    {
        public string? Name { get; set; }
        public string? Rate { get; set; }
        public string? Unit { get; set; }
        public string? Weight { get; set; }
        public int? ItemSequence { get; set; }
        public int? AccountDetailId { get; set; }
        public AccountDetail accountDetail { get; set; }
        public ICollection<ItemRate> ItemRates { get; set; }
    }
}
