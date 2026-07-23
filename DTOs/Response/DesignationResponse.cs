namespace InvoiceMenagment.Api.DTOs.Response
{
    public class DesignationResponse
    {
        public int Id { get; set; }
        public string DesignationTitle { get; set; } = string.Empty;
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }   // convenience field for grid display
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

    }
}
