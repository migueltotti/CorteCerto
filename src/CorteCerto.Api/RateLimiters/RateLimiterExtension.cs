using System.Threading.RateLimiting;

namespace CorteCerto.Api.RateLimiters;

public static class RateLimiterExtension
{
    public static IServiceCollection AddRateLimiters(this IServiceCollection services)
    {
        services.AddRateLimiter(options =>
        {
            options.RejectionStatusCode = StatusCodes.Status429TooManyRequests;

            options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(context =>
                RateLimitPartition.GetFixedWindowLimiter(
                    partitionKey: context.Connection.RemoteIpAddress?.ToString() ?? "anonymous",
                    factory: _ => new FixedWindowRateLimiterOptions
                    {
                        PermitLimit = 15,
                        Window = TimeSpan.FromMinutes(1),
                        QueueLimit = 5,
                        AutoReplenishment = true
                    }));
        });
        
        return services;
    }
}