using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMenagment.Api.Models
{
    public class RoleControlPermission : BasicEntity
    {
        public int? RolePagePermissionId { get; set; }
        public RolePagePermission? RolePagePermission { get; set; }
        public int? PageId { get; set; }
        public int? ControlId { get; set; }
        public bool? IsView { get; set; }

        public int? RoleId { get; set; }
        public Role? Role { get; set; }

    }
}
