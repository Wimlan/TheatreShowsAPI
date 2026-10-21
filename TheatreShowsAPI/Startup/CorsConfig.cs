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
                    .WithOrigins("http://localhost:5173", "https://thetheatrelibrary.onrender.com")
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
