using System.ComponentModel.DataAnnotations;

namespace InvoiceMenagment.Api.DTOs.Requests
{
    public class DesignationRequest
    {
        public int Id { get; set; }   // 0 => Create, >0 => Update

        [Required]
        [MaxLength(100)]
        public string DesignationTitle { get; set; } = string.Empty;

        public int? DepartmentId { get; set; }

        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

    }
}
