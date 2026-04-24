using System.Runtime.CompilerServices;
using TheatreShowsAPI.Data;

namespace TheatreShowsAPI.Startup
{
    //extension methods have to be in a static class
    public static class DependenciesConfig
    {
        public static void AddDependencies(this WebApplicationBuilder builder) 
        {
            

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApiServices();
            builder.Services.AddCorsServices();
            builder.Services.AddTransient<ShowData>();
        }
    }
}
