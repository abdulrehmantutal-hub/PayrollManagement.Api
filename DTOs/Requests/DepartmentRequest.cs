using System.ComponentModel.DataAnnotations;

namespace InvoiceMenagment.Api.DTOs.Requests
{
    public class CreateDepartmentRequest
    {
        [Required]
        [MaxLength(100)]
        public string DepartmentName { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? DepartmentCode { get; set; }

        public string? Description { get; set; }
    }

    public class UpdateDepartmentRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string DepartmentName { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? DepartmentCode { get; set; }

        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}