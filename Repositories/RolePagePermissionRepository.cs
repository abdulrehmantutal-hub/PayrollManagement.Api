using InvoiceMenagment.Api.Data;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Repositories.Interfaces;
using InvoiceMenagment.Api.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace InvoiceMenagment.Api.Repositories
{
    public class RolePagePermissionRepository : GenericRepository<RolePagePermission>, IRolePagePermissionRepository
    {
        public RolePagePermissionRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        // Fetch role page permissions by roleId
        public async Task<List<RolePagePermission>> GetByRoleIdAsync(int roleId)
        {
            return await _context.rolePagePermission
                .Where(rpp => rpp.RoleId == roleId)
                .ToListAsync();
        }



    }
}