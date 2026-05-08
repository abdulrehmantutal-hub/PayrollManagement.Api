namespace InvoiceMenagment.Api.Models
{
    public class SalePerson : BasicEntity
    {

        public string? Name { get; set; }
        public string? ContactNumber { get; set; }
        public string? WhatsappNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public bool? IsBooker { get; set; }
        public bool? IsSaleMen { get; set; }

        public bool? IsDriver { get; set; }




        //public int? DriverId { get; set; }
        //public LookUpName? Driver { get; set; }

        //public string? VehicleNumber { get; set; }

        //// Relationships
        //public ICollection<SalePersonLoader> SalePersonLoaders { get; set; }
        //public ICollection<SectorAssignSaleMen> SectorAssignSaleMen { get; set; }
    }
}
