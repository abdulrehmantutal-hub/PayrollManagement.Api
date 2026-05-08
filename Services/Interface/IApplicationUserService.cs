
using InvoiceMenagment.Api.DTOs.Request;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Http;
using InvoiceMenagment.Api.Models;


namespace InvoiceMenagment.Api.Services
{
    public interface IApplicationUserService
    {

        Task<ResponseModel<IEnumerable<ApplicationUserResponse>>> GetAllUsersAsync();
        Task<ResponseModel<ApplicationUserResponse>> GetUserByGlobalIdAsync(Guid GlobalId);
        Task<ResponseModel<ApplicationUserResponse>> GetUserByTokenAsync();
        Task<ResponseModel<ApplicationUserResponse>> RegisterUserAsync(ApplicationUserRequestDto request);
        Task<ResponseModel<string>> ForgotPasswordAsync(ForgotPasswordRequestDto request);
        Task<ResponseModel<ApplicationUserResponse>> UpdateUserAsync(Guid globalId, ApplicationUserRequestDto request);
        Task<ResponseModel<ApplicationUserResponse>> DeleteUserAsync(Guid globalId);
        Task<ResponseModel<PageResult<ApplicationUserResponse>>> Search(SearchRequest searchRequest);
        Task<ResponseModel<string>> UploadUserImageAsync(int UserId, IFormFile imageFile);

        Task<ResponseModel<string>> ResetPasswordAsync(ResetPasswordRequest request);
    }
}
