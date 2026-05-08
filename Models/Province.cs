using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMenagment.Api.Models
{
    public class Province : BasicEntity 
    {
       
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? CountryCode { get; set; } 
        public int? CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; }
    }
}
