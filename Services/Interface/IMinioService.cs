using InvoiceMenagment.Api.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceMenagment.Api.Services.Interfaces
{
    public interface IMinioService
    {
       
        Task<ResponseModel<string>> UploadFileAsync(Stream fileStream, string fileName, string contentType, string folder );

    }
}