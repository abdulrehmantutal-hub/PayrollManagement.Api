using AutoMapper;
using InvoiceMenagment.Api.Data;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Repositories.Interface;
using InvoiceMenagment.Api.Repository;
using Microsoft.EntityFrameworkCore;

namespace InvoiceMenagment.Api.Repositories
{
    public class DesignationRepository : GenericRepository<Designation>, IDesignationRepository

    {
        public DesignationRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<Designation> GetByTitleAsync(string designationTitle)
        {
            return await _dbSet.FirstOrDefaultAsync(d => d.DesignationTitle == designationTitle && !d.IsDeleted);
        }

        public async Task<bool> IsTitleExistsAsync(string designationTitle, int? excludeId = null)
        {
            return await _dbSet.AnyAsync(d =>
                d.DesignationTitle == designationTitle
                && !d.IsDeleted
                && (!excludeId.HasValue || d.Id != excludeId.Value));
        }

        public async Task<IList<Designation>> GetAllActiveAsync()
        {
            return await _context.Designations
                                 .Include(d => d.Department)
                                 .Where(d => d.IsActive && !d.IsDeleted)
                                 .ToListAsync();
        }
    }

}
