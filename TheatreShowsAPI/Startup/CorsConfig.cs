using Scalar.AspNetCore;

namespace TheatreShowsAPI.Startup;

public static class CorsConfig
{
    private const string SpecificOriginPolicy = "AllowSpecificOrigin";

    public static void AddCorsServices(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(SpecificOriginPolicy, policy =>
            {
                policy
                    .WithOrigins("https://localhost:7048", "https://wilmayasuda.se") // exact origin (scheme + host [+ :port])
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                    // .AllowCredentials(); // enable only if you need cookies/credentials
            });
        });
    }

    public static void ApplyCorsConfig(this WebApplication app)
    {
        app.UseCors(SpecificOriginPolicy);
    }
}
