using InvoiceMenagment.Api.DTOs.Requests;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Http;
using InvoiceMenagment.Api.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceMenagment.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _service;

        public DepartmentsController(IDepartmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result.HttpStatusCode == 404) return NotFound(result);
            return Ok(result);
        }

        // Id = 0 (or not sent) => Create, Id > 0 => Update
        [HttpPost]
        public async Task<ActionResult<ResponseModel<DepartmentResponse?>>> Save([FromBody] UpdateDepartmentRequest request)
        {
            var response = await _service.SaveAsync(request);

            return response.HttpStatusCode switch
            {
                200 or 201 => StatusCode(response.HttpStatusCode, response),
                400 => BadRequest(response),
                404 => NotFound(response),
                _ => StatusCode(500, response)
            };
        }

        [HttpPatch("{id}/deactivate")]
        public async Task<IActionResult> Deactivate(int id)
        {
            var result = await _service.DeactivateAsync(id);
            if (result.HttpStatusCode == 404) return NotFound(result);
            return Ok(result);
        }
    }
}