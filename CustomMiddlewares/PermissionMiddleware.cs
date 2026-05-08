using System.Security.Claims;

namespace InvoiceMenagment.Api.CustomMiddlewares
{
    public class PermissionMiddleware
    {
        private readonly RequestDelegate _next;

        public PermissionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var userRole = context.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;

            // Check if the user has permission for the requested resource.
            // For example, get the page id from the URL and check the role permissions.

            // If no permission, return Forbidden
            if (!HasPermission(userRole))
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                return;
            }

            await _next(context);
        }

        private bool HasPermission(string userRole)
        {
            // Implement your permission check logic here
            return true;
        }
    }

}
