namespace InvoiceMenagment.Api.Models
{
    public class LookUpName : BasicEntity
    {
        public string? Name { get; set; }
        public string? Type { get; set; }

        //public ICollection<SalePerson> Drivers { get; set; }
        //public ICollection<SalePersonLoader> Loaders { get; set; } 
        //public ICollection<SectorAssignSaleMen> Sectors { get; set; } 
    }
}
