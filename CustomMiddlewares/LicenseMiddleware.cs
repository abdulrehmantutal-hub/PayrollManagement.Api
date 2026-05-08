using System.Security.Claims;
using InvoiceMenagment.Api.Data;
using InvoiceMenagment.Api.Services;
using InvoiceMenagment.Api.Services.Interfaces;

namespace InvoiceMenagment.Api.CustomMiddlewares
{
    public class LicenseMiddleware
    {
        private readonly RequestDelegate _next;

        public LicenseMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ILicenseService licenseService)
        {
            var path = context.Request.Path.ToString().ToLower();

            // Allow license upload and Swagger-related endpoints to bypass validation
            if (path.Contains("/api/license/upload") ||
                path.Contains("/api/license/generate") ||
                path.StartsWith("/swagger") ||
                path.Contains("favicon") ||
                path.Contains("index.html"))
            {
                await _next(context);
                return;
            }

            // Add license status to response headers
            var statusMessage = licenseService.GetLicenseStatusMessage();
            context.Response.OnStarting(() =>
            {
                context.Response.Headers["X-License-Status"] = statusMessage;
                return Task.CompletedTask;
            });

            // Check license validity
            if (!licenseService.IsLicenseValid())
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Your license has expired.");
                return;
            }

            await _next(context);
        }

    }

}
