using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMenagment.Api.Models
{
    public class District : BasicEntity
    {
       
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? CountryCode { get; set; } 
        public int? ProvinceId { get; set; } 
        public string? ProvinceCode { get; set; } 
        public int? CountryId { get; set; }

        public Country Country { get; set; }

        public Province Province { get; set; }
    }
}
