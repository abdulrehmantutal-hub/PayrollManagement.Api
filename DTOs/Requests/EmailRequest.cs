namespace InvoiceMenagment.Api.DTOs.Request
{
    public class EmailRequest
    {
        public string EmailTo { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        
    }
}
