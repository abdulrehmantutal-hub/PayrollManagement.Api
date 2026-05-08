    namespace InvoiceMenagment.Api.Models
    {
    public class StockAdjustmentParameter : BasicEntity
    {
        public int? StockAdjustmentId { get; set; }
        public virtual StockAdjustment? Master { get; set; }
        public int ItemAccountId { get; set; }
        public virtual AccountDetail? ItemAccount { get; set; }
        public int? StockAdjustmentStatusId { get; set; }
        public virtual LookUpName? StockAdjustmentStatus { get; set; }
        public decimal? Quantity { get; set; }
        public string? Remarks { get; set; }
    }
}
