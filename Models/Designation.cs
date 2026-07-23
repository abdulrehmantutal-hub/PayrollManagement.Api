using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMenagment.Api.Models
{
    public class Designation : BasicEntity

    {
        [Required]
        [MaxLength(100)]
        public string DesignationTitle { get; set; } = string.Empty;

        // Optional FK — department-specific designation
        public int? DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public Department? Department { get; set; }

        public string? Description { get; set; }

    }
}
