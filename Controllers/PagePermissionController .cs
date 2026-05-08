using InvoiceMenagment.Api.DTOs.Request;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceMenagment.Api.Controllers
{
    public class PagePermissionController : BaseApiController
    {
        private readonly IPagePermissionService _pagePermissionService;

        public PagePermissionController(IPagePermissionService pagePermissionService)
        {
            _pagePermissionService = pagePermissionService;
        }

        [HttpGet("{roleId}")]
        public async Task<ActionResult<IEnumerable<RolePagePermission>>> GetPagePermissionsByRoleIdAsync(int roleId)
        {
            var permissions = await _pagePermissionService.GetPagePermissionsByRoleIdAsync(roleId);
            return Ok(permissions);
        }



        [HttpPost("Assign")]
        public async Task<ActionResult> AssignPagePermissionsToRoleAsync([FromBody] PageModuleRequest request)
        {
            if (request.RoleId <= 0 || request.PageIds == null || request.PageIds.Count == 0)
            {
                return BadRequest("Invalid request data.");
            }

            await _pagePermissionService.AssignPagePermissionsToRoleAsync(request.RoleId, request.PageIds);
            return NoContent();



        }

    }
}
