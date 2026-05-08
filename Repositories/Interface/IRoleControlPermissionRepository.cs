using InvoiceMenagment.Api.Models;

namespace InvoiceMenagment.Api.Repositories.Interfaces
{
    public interface IRoleControlPermissionRepository : IGenericRepository<RoleControlPermission>
    {
        //Task<IEnumerable<RoleControlPermission>> GetByRoleIdAsync(int roleId);
        Task<List<RoleControlPermission>> GetByRoleIdAsync(int roleId);
        Task DeleteRangeAsyncNew(IEnumerable<RoleControlPermission> permissions);


        Task<List<RoleControlPermission>> GetByRolePagePermissionIdAsync(int rolePagePermissionId);
    }
}
