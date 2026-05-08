using InvoiceMenagment.Api.Models;

namespace InvoiceMenagment.Api.Services.Interfaces
{
    public interface IPagePermissionService
    {
        Task<IEnumerable<RolePagePermission>> GetPagePermissionsByRoleIdAsync(int roleId);
        Task AssignPagePermissionsToRoleAsync(int roleId, IEnumerable<int?> pageIds);
    }

}
