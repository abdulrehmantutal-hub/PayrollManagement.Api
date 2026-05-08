namespace InvoiceMenagment.Api.Models
{
    public class GlobalAccount : BasicEntity
    {

        public int? AccountdetailId { get; set; }
        public AccountDetail AccoountDetail { get; set; }
        public string? AutoNumber { get; set; }
       public string? Name { get; set; }
       public string? Type { get; set; }
        public string? test { get; set; }

    }
}
