using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Models;

namespace InvoiceMenagment.Api.Repositories.Interfaces
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        Task<Role> GetByNameAsync(string name);

        Task<Role> GetListByIdAsync(int id);

    }
}
