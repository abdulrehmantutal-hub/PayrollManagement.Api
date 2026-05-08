    namespace InvoiceMenagment.Api.Models
    {
    public class StockParameters : BasicEntity
    {
        public int? StockId { get; set; }
        public virtual Stock? Master { get; set; }
        public int ItemAccountId { get; set; }
        public virtual AccountDetail? ItemAccount { get; set; }
        public string? Quantity { get; set; }
        public string? Remarks { get; set; }
    }
}
