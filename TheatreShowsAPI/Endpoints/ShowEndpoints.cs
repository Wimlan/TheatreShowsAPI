using TheatreShowsAPI.Data;
using Microsoft.AspNetCore.Builder;

namespace TheatreShowsAPI.Endpoints
{
    public static class ShowEndpoints
    {
        public static void AddShowEndpoints(this WebApplication app)
        {
            app.MapGet("/shows", LoadAllShows);
            app.MapGet("/shows/{id}", LoadShowById);
        }

        private static IResult LoadAllShows(ShowData data) 
        { 
        return Results.Ok(data.Shows);
        }

        private static IResult LoadShowById(ShowData data, int id)
        {
            return Results.Ok(data.Shows.SingleOrDefault(s => s.Id == id));
               }
    }
}
