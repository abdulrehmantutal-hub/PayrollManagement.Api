using InvoiceMenagment.Api.DTOs.Requests;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Http;

namespace InvoiceMenagment.Api.Services.Interface
{
    public interface IDesignationService
    {
        Task<ResponseModel<IEnumerable<DesignationResponse>>> GetAllAsync();
        Task<ResponseModel<DesignationResponse?>> GetByIdAsync(int id);
        Task<ResponseModel<DesignationResponse?>> SaveAsync(DesignationRequest request);
        Task<ResponseModel<bool>> DeactivateAsync(int id);

    }
}
