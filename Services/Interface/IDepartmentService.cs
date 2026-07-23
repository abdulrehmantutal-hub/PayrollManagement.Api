using InvoiceMenagment.Api.DTOs.Requests;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Http;

namespace InvoiceMenagment.Api.Services.Interface
{
    public interface IDepartmentService
    {
        Task<ResponseModel<IEnumerable<DepartmentResponse>>> GetAllAsync();
        Task<ResponseModel<DepartmentResponse?>> GetByIdAsync(int id);
        Task<ResponseModel<DepartmentResponse?>> SaveAsync(UpdateDepartmentRequest request);
        Task<ResponseModel<bool>> DeactivateAsync(int id);
    }
}