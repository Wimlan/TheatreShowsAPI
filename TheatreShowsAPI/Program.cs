using Scalar.AspNetCore;
using TheatreShowsAPI.Endpoints;
using TheatreShowsAPI.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.AddDependencies();

var app = builder.Build();

app.UseOpenApi();

app.UseHttpsRedirection();

app.AddRootEndpoints();

app.AddShowEndpoints();

app.UseAuthorization();

app.Run();
