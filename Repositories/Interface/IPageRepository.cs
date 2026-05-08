using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Models;

namespace InvoiceMenagment.Api.Repositories.Interfaces
{
    public interface IPageRepository : IGenericRepository<Page>
    {
        Task<IEnumerable<Page>> GetPagesWithControlsAsync();
    }
}
