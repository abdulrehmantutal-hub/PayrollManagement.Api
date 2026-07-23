using System.ComponentModel.DataAnnotations;

namespace InvoiceMenagment.Api.Models
{
    public class Department : BasicEntity
    {
        
        [Required]
        [MaxLength(100)]
        public string DepartmentName { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? DepartmentCode { get; set; }

        public string? Description { get; set; }

        // Navigation
        //public ICollection<Designation>? Designations { get; set; }
        //public ICollection<Employee>? Employees { get; set; }
    }


}
