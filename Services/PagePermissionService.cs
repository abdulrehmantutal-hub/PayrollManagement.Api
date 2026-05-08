using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Repositories.Interfaces;
using InvoiceMenagment.Api.Services.Interfaces;
// Ensure the correct namespace for RolePermission

namespace InvoiceMenagment.Api.Services
{
    public class PagePermissionService : IPagePermissionService
    {
        private readonly IGenericRepository<RolePagePermission> _rolePagePermissionRepository;

        public PagePermissionService(IGenericRepository<RolePagePermission> rolePagePermissionRepository)
        {
            _rolePagePermissionRepository = rolePagePermissionRepository;
        }

        // Get all page permissions for a specific role
        public async Task<IEnumerable<RolePagePermission>> GetPagePermissionsByRoleIdAsync(int roleId)
        {
            return await _rolePagePermissionRepository.FindAsync(rpp => rpp.RoleId == roleId);
        }

        // Assign page permissions to a role
        public async Task AssignPagePermissionsToRoleAsync(int roleId, IEnumerable<int?> pageIds)
        {
            var validPageIds = pageIds.Where(id => id.HasValue).Select(id => id.Value).ToList();
            var rolePagePermissions = validPageIds.Select(pageId => new RolePagePermission
            {
                RoleId = roleId,
                PageId = pageId
            }).ToList();

            await _rolePagePermissionRepository.AddRangeAsync(rolePagePermissions);
        }


        // Remove page permissions from a role
        //public async Task RemovePagePermissionsFromRoleAsync(int roleId, IEnumerable<int?> pageIds)
        //{
        //    var validPageIds = pageIds.Where(id => id.HasValue).Select(id => id.Value).ToList();
        //    var rolePagePermissions = await _rolePagePermissionRepository.FindAsync(rpp => rpp.RoleId == roleId && validPageIds.Contains(rpp.PageId));
        //    await _rolePagePermissionRepository.PermanentDeleteRangeAsync(rolePagePermissions);
        //}
    }
}
