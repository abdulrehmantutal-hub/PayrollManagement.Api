using InvoiceMenagment.Api.Models;

namespace InvoiceMenagment.Api.DTOs.Response
{
    public class PageControlResponse : BasicEntity
    {
        public int? PageId { get; set; }
        public string? Name { get; set; }
    }
}
