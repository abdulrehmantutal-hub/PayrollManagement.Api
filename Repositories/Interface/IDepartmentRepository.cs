using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Repositories.Interfaces;

namespace InvoiceMenagment.Api.Repositories.Interface
{
    public interface IDepartmentRepository : IGenericRepository<Department>
    {
        Task<Department> GetByNameAsync(string departmentName);
        Task<bool> IsNameExistsAsync(string departmentName, int? excludeId = null);
        Task<IList<Department>> GetAllActiveAsync();
    }


}
