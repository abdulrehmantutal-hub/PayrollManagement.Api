using InvoiceMenagment.Api.Models;

namespace InvoiceMenagment.Api.DTOs.Request
{
    public class RoleControlPermissionRequest : BasicEntity
    {
        public int? RolePagePermissionId { get; set; }
        public int? PageId { get; set; }
        public int? RoleId { get; set; }
        public int? ControlId { get; set; }
        public bool? IsView { get; set; }

    }
}
