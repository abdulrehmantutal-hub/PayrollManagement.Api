using InvoiceMenagment.Api.DTOs.Request;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Http;

namespace InvoiceMenagment.Api.Services.Interfaces
{
    public interface IPageControlService
    {
        //Task<ResponseModel<PageControlResponse>> AddPageControlAsync(PageControlRequestDto request);
        //Task<ResponseModel<PageControlResponse?>> GetPageControlByIdAsync(int id);

        //Task<ResponseModel<IEnumerable<PageControlResponse>>> GetAllPageControlsAsync();

        //Task<ResponseModel<PageControlResponse?>> UpdatePageControlAsync(int id, PageControlRequestDto request);
        //Task<ResponseModel<bool>> DeletePageControlAsync(Guid globalId);

        Task<ResponseModel<PageControlResponse>> AddPageControlAsync(PageControlRequest request);
        Task<ResponseModel<PageControlResponse?>> GetPageControlByIdAsync(int id);

        Task<ResponseModel<IEnumerable<PageControlResponse>>> GetAllPageControlsAsync();

        Task<ResponseModel<PageControlResponse?>> UpdatePageControlAsync(int id, PageControlRequest request);
        Task<ResponseModel<bool>> DeletePageControlAsync(Guid globalId);
    }
}
