using Scalar.AspNetCore;
using TheatreShowsAPI.Endpoints;
using TheatreShowsAPI.Startup;

namespace TheatreShowsAPI
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.AddDependencies();

            var app = builder.Build();

            app.UseOpenApi();

            app.UseHttpsRedirection();

            app.ApplyCorsConfig();

            app.AddRootEndpoints();

            app.AddShowEndpoints();

            //app.UseAuthorization();

            app.Run();
        }
    }
}
