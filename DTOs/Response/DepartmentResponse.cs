namespace InvoiceMenagment.Api.DTOs.Response
{
    public class DepartmentResponse
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public string? DepartmentCode { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }


    }
}
