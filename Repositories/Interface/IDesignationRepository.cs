using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Repositories.Interfaces;

namespace InvoiceMenagment.Api.Repositories.Interface
{
    public interface IDesignationRepository : IGenericRepository<Designation>

    {
        Task<Designation> GetByTitleAsync(string designationTitle);
        Task<bool> IsTitleExistsAsync(string designationTitle, int? excludeId = null);
        Task<IList<Designation>> GetAllActiveAsync();
    }

}
