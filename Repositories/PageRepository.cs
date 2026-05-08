using InvoiceMenagment.Api.Data;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Repositories.Interfaces;
using InvoiceMenagment.Api.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace InvoiceMenagment.Api.Repositories
{
    public class PageRepository : GenericRepository<Page>, IPageRepository
    {
        public PageRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<IEnumerable<Page>> GetPagesWithControlsAsync()
        {
            var Page = await _context.page
                 //.Include(p => p.PageControls)
                 //.Include(x => x.RolePagePermissions)
                 .AsNoTracking()
                .ToListAsync();
            return Page;
        }



    }
} 
