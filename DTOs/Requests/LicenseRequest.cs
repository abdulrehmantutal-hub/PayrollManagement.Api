namespace InvoiceMenagment.Api.DTOs.Request
{
    public class LicenseRequest
    {
        public string ClientId { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

}
