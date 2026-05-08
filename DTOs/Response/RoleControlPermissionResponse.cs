using InvoiceMenagment.Api.Models;

namespace InvoiceMenagment.Api.DTOs.Response
{
    public class RoleControlPermissionResponse : BasicEntity
    {
        public int? RolePagePermissionId { get; set; }
        public int? PageId { get; set; }
        public int? ControlId { get; set; }
        public bool? IsView { get; set; }
    }
}
