using AutoMapper;
using InvoiceMenagment.Api.Data;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace InvoiceMenagment.Api.Repository
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<Department> GetByNameAsync(string departmentName)
        {
            return await _dbSet.FirstOrDefaultAsync(d => d.DepartmentName == departmentName && !d.IsDeleted);
        }

        public async Task<bool> IsNameExistsAsync(string departmentName, int? excludeId = null)
        {
            return await _dbSet.AnyAsync(d =>
                d.DepartmentName == departmentName
                && !d.IsDeleted
                && (!excludeId.HasValue || d.Id != excludeId.Value));
        }

        public async Task<IList<Department>> GetAllActiveAsync()
        {
            return await _context.Departments
                                 .Where(d => d.IsActive && !d.IsDeleted)
                                 .ToListAsync();
        }
    }
}