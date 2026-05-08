namespace InvoiceMenagment.Api.Models
{
    public class SaleDashboard : BasicEntity
    {
        public DateTime SaleDate { get; set; }
        public string? ItemColorCode { get; set; }
        public string? ItemName { get; set; }
        public string? SalesGrossAmount { get; set; }
    }
}
