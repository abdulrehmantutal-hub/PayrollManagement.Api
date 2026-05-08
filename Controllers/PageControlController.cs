using InvoiceMenagment.Api.DTOs.Request;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Http;
using InvoiceMenagment.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceMenagment.Api.Controllers
{ 
    public class PageControlController : BaseApiController
    {
        private readonly IPageControlService _pageControlService;

        public PageControlController(IPageControlService pageControlService)
        {
            _pageControlService = pageControlService;
        }

        [HttpGet("getAll")]
        public async Task<ResponseModel<IEnumerable<PageControlResponse>>> GetAllPageControls()
        {
            var result = await _pageControlService.GetAllPageControlsAsync();
            return result;
        }


        [HttpGet("getById")]
        public async Task<ResponseModel<PageControlResponse>> GetPageControlById([FromQuery] int id)
        {
            var result = await _pageControlService.GetPageControlByIdAsync(id);
            return result;
        }

        [HttpPost("create")]
        public async Task<ResponseModel<PageControlResponse>> CreatePageControl([FromBody] PageControlRequest request)
        {
            var result = await _pageControlService.AddPageControlAsync(request);
            return result;
        }

        [HttpPut("update")]
        public async Task<ResponseModel<PageControlResponse>> UpdatePageControl([FromQuery] int id, [FromBody] PageControlRequest request)
        {
            var result = await _pageControlService.UpdatePageControlAsync(id, request);
            return result;
        }

        [HttpDelete("deleteByGlobalId")]
        public async Task<ResponseModel<bool>> DeletePageControl([FromQuery] Guid globalId)
        {
            var result = await _pageControlService.DeletePageControlAsync(globalId);
            return result;
        }
    }
}
