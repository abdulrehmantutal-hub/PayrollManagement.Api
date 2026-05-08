using System.ComponentModel.DataAnnotations;


namespace InvoiceMenagment.Api.Models
{
    public class Country : BasicEntity
    {
       
        public string? Code { get; set; }       
        public string? Name { get; set; }
    }
}
