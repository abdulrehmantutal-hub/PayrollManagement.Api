using InvoiceMenagment.Api.Models;

namespace InvoiceMenagment.Api.Repositories.Interfaces
{
    public interface IRolePagePermissionRepository : IGenericRepository<RolePagePermission>
    {
        Task<List<RolePagePermission>> GetByRoleIdAsync(int roleId);
    }
}
