namespace InvoiceMenagment.Api.Models
{
    public class ItemRate : BasicEntity
    {
        public string? Rate { get; set; }
        public DateTime? EffectiveFromDate { get; set; }

        
        public int? ItemId { get; set; }
        public Item? Item { get; set; }
    }
}
