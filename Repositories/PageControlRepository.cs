using InvoiceMenagment.Api.Data;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Repositories.Interfaces;
using InvoiceMenagment.Api.Repository;
using AutoMapper;

namespace InvoiceMenagment.Api.Repositories
{
    public class PageControlRepository : GenericRepository<Control>, IPageControlRepository
    {
        public PageControlRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
