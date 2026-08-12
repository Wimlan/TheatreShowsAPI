using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using TheatreShowsAPI.Endpoints;
using TheatreShowsAPI.Startup;
using TheatreShowsAPI.Data;

namespace TheatreShowsAPI
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.AddDependencies();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

            builder.Services.AddScoped<IShowRepository, EfShowRepository>();

            var app = builder.Build();

            app.UseOpenApi();

            app.UseHttpsRedirection();

            app.ApplyCorsConfig();

            app.MapAllHealthChecks();

            app.AddRootEndpoints();
            app.AddErrorEndpoints();
            app.AddShowEndpoints();

            //app.UseAuthorization();

            app.Run();
        }
    }
}
