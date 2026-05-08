using InvoiceMenagment.Api.Models.InvoiceMenagment.Api.Models;

namespace InvoiceMenagment.Api.Models
{
    public class SaleBillTypeParameter :BasicEntity
    {
        public int? SaleId { get; set; }
        public int? BillTypeId { get; set; }

        public Sale Sale { get; set; }
        public LookUpName BillType { get; set; }
    }
}
