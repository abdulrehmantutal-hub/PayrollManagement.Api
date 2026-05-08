using System.Security.Claims;
using InvoiceMenagment.Api.Data;

namespace InvoiceMenagment.Api.CustomMiddlewares
{
    public class SubscriptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<SubscriptionMiddleware> _logger;

        public SubscriptionMiddleware(RequestDelegate next, ILogger<SubscriptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        //public async Task InvokeAsync(HttpContext context, ApplicationDbContext dbContext)
        //{
        //    // ClientId header se lo
        //    var clientIdHeader = context.Request.Headers["ClientId"].FirstOrDefault();

        //    if (string.IsNullOrEmpty(clientIdHeader) || !Guid.TryParse(clientIdHeader, out Guid clientId))
        //    {
        //        context.Response.StatusCode = StatusCodes.Status400BadRequest;
        //        await context.Response.WriteAsync("Missing or invalid ClientId");
        //        return;
        //    }

        //    // Subscription check karo
        //    var subscription = dbContext.Subscription
        //        .Where(s => s.ClientId == clientId && s.IsActive)
        //        .OrderByDescending(s => s.SubscriptionEnd)
        //        .FirstOrDefault();

        //    if (subscription == null || subscription.SubscriptionEnd < DateTime.UtcNow)
        //    {
        //        context.Response.StatusCode = StatusCodes.Status403Forbidden;
        //        await context.Response.WriteAsync("Your subscription has expired.");
        //        return;
        //    }

        //    // Warning agar 7 din se kam bache hon
        //    var daysLeft = (subscription.SubscriptionEnd - DateTime.UtcNow).TotalDays;
        //    if (daysLeft <= 7)
        //    {
        //        context.Response.Headers.Add("Subscription-Warning", "Subscription will expire in " + Math.Floor(daysLeft) + " days.");
        //    }

        //    // Next middleware ya controller chalay
        //    await _next(context);

        //}


        public async Task InvokeAsync(HttpContext context, ApplicationDbContext dbContext)
        {
            // 🔧 Temporary hardcoded ClientId for testing
            var clientIdHeader = context.Request.Headers["ClientId"].FirstOrDefault();

            if (string.IsNullOrEmpty(clientIdHeader))
            {
                // Default client ID set karo agar header nahi diya gaya
                clientIdHeader = "81eb8122-118b-4013-ab6f-c26b39b59149";
                context.Request.Headers["ClientId"] = clientIdHeader;
            }

            if (!Guid.TryParse(clientIdHeader, out Guid clientId))
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync("Missing or invalid ClientId");
                return;
            }

            var subscription = dbContext.Subscription
                .Where(s => s.ClientId == clientId && s.IsActive)
                .OrderByDescending(s => s.SubscriptionEnd)
                .FirstOrDefault();

            if (subscription == null || subscription.SubscriptionEnd < DateTime.UtcNow)
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Your subscription has expired.");
                return;
            }

            var daysLeft = (subscription.SubscriptionEnd - DateTime.UtcNow).TotalDays;
            if (daysLeft <= 7)
            {
                context.Response.Headers.Add("Subscription-Warning", "Subscription will expire in " + Math.Floor(daysLeft) + " days.");
            }

            await _next(context);
        }

    }

}
