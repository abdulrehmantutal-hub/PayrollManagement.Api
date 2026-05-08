namespace InvoiceMenagment.Api.DTOs.Response
{
    public class PageControlResponseDto 
    {
        public int Id { get; set; }
        public string ControlName { get; set; }
        public int ParentId { get; set; } // ID of the Page it belongs to
    }
}
