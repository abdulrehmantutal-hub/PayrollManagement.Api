namespace InvoiceMenagment.Api.Models
{
    public class StockConfigrationMaster : BasicEntity
    {
        public string? AutoNumber { get; set; }
        public ICollection<StockConfig> StockConfigs { get; set; } = new List<StockConfig>();
    }

}
