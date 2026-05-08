using Newtonsoft.Json;

namespace InvoiceMenagment.Api.Models
{
    namespace InvoiceMenagment.Api.Models
    {
        public class Sale : BasicEntity
        {
            public string AutoNumber { get; set; }
            public string Date { get; set; }
            public string? DeliveryChallan { get; set; }
            public int? CustomerId { get; set; }
            public AccountDetail Customer { get; set; }
            public int? SalePersonId { get; set; }
            public SalePerson SalePerson { get; set; }

            public int?  DriverId { get; set; }
            public SalePerson Driver { get; set; }

            public int?  BookerId { get; set; }
            public SalePerson Booker { get; set; }
            public string VehicleNumber { get; set; }
            public ICollection<SaleParameter> SaleParameters { get; set; }

        }



    }

}
