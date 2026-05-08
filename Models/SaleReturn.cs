using Newtonsoft.Json;

namespace InvoiceMenagment.Api.Models
{
    public class SaleReturn : BasicEntity
    {
        public string? AutoNumber { get; set; }
        public string? Date { get; set; }
        public int? CustomerId { get; set; }
        public AccountDetail Customer { get; set; }
        public string? VehicleNumber { get; set; }
        public string? DeliveryChallan { get; set; }
        public int? SalePersonId { get; set; }
        public SalePerson SalePerson { get; set; }

        public int? DriverId { get; set; }
        public SalePerson Driver { get; set; }

        public int? BookerId { get; set; }
        public SalePerson Booker { get; set; }
    
        [JsonIgnore]
        public ICollection<SaleReturnParameter>? SaleReturnParameters { get; set; }
    }

}


