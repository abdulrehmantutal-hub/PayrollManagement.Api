using Microsoft.EntityFrameworkCore;
using System.Linq;
using InvoiceMenagment.Api.Data;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Repositories.Interfaces;
using InvoiceMenagment.Api.Repository;
using AutoMapper;

namespace InvoiceMenagment.Api.Repositories
{
    public class RoleControlPermissionRepository : GenericRepository<RoleControlPermission>, IRoleControlPermissionRepository
    {
        public RoleControlPermissionRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        //public async Task<List<RoleControlPermission>> GetByRoleIdAsync(int roleId)
        //{
        //    return await _context.RoleControlPermissions
        //        .Where(rp => rp.RoleId == roleId)
        //        .ToListAsync();  // This ensures that the query uses Entity Framework's async functionality
        //}

        //public async Task<List<RoleControlPermission>> GetByRoleIdAsync(int roleId)
        //{
        //    return await _context.RoleControlPermissions
        //        .Where(rpp => rpp.RoleId == roleId)
        //        .ToListAsync();

        //}

        //public async Task<List<RoleControlPermission>> GetByRoleIdAsync(int roleId)
        //{
        //    // Ensure we're directly querying the DbSet which is inherently async-capable
        //    return await _context.RoleControlPermissions
        //        .Where(rpp => rpp.RoleId == roleId)
        //        .ToListAsync();  // This ensures async execution on the DbSet
        //}

        //public Task<List<RoleControlPermission>> GetByRoleIdAsync(int roleId)
        //{
        //    // Make sure to use the DbSet and return a Task
        //    return _context.RoleControlPermissions
        //        .Where(rp => rp.RoleId == roleId)
        //        .ToListAsync();  // This ensures async operation
        //}


        public async Task<List<RoleControlPermission>> GetByRoleIdAsync(int roleId)
        {
            // Ensure that RoleControlPermissions is a DbSet in your context
            return await _context.RoleControlPermissions
                .Where(rp => rp.RoleId == roleId)
                .ToListAsync();  // This works with DbSet and supports async operations
        }

        public async Task DeleteRangeAsyncNew(IEnumerable<RoleControlPermission> permissions)
        {
            _context.RoleControlPermissions.RemoveRange(permissions);
            await _context.SaveChangesAsync();  // Commit changes asynchronously
        }



        public async Task<List<RoleControlPermission>> GetByRolePagePermissionIdAsync(int rolePagePermissionId)
        {
            return await _context.RoleControlPermissions
                .Where(rccp => rccp.RolePagePermissionId == rolePagePermissionId)
                .ToListAsync(); // Async operation for getting permissions by RolePagePermissionId
        }
    }
}
