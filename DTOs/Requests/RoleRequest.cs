using InvoiceMenagment.Api.Models;

namespace InvoiceMenagment.Api.DTOs.Request
{
    public class RoleRequest : BasicEntity
    {
        public Guid? GlobalId { get; set; }

        public string Name { get; set; }
        public List<RolePagePermissionRequest> RolePagePermissions { get; set; }
    }


}
