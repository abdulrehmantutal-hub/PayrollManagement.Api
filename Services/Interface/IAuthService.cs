using InvoiceMenagment.Api.Http;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Request;
using InvoiceMenagment.Api.Response;


namespace InvoiceMenagment.Api.Services
{
    public interface IAuthService
    {

        Task<AuthResponseDto> Authenticate(AuthRequestDto request);
        //Task<ResponseModel<ApplicationUser>> ResetPasswordAsync(ResetPasswordRequestDto request);
    }
}
