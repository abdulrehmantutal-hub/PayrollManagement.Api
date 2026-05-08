using InvoiceMenagment.Api.Models.InvoiceMenagment.Api.Models;

namespace InvoiceMenagment.Api.Models
{
    public class LoaderParameter : BasicEntity
    {
        public int? SaleId { get; set; }

        public Sale Sale { get; set; }
        //public List<int> LoaderIds { get; set; } = new List<int>();
        
        public int LoaderId { get; set; }
    }
}
