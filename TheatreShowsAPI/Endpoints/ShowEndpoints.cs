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

        private static IResult LoadAllShows(
            ShowData data,
            string? showType,
            string? search) 
        {
            var output = data.Shows;
            if (string.IsNullOrWhiteSpace(showType) == false)
            { 
            output.RemoveAll(x=> string.Compare(
                x.ShowType,
                showType, 
                StringComparison.OrdinalIgnoreCase) != 0);
            }

            if(string.IsNullOrWhiteSpace(search) == false)
            {
                output.RemoveAll(x => !x.Title.Contains(search, StringComparison.OrdinalIgnoreCase) &&
                !x.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
            }


        return Results.Ok(output);
        }

        private static IResult LoadShowById(ShowData data, int id)
        {
            var output = data.Shows.SingleOrDefault(s => s.Id == id);
            if(output is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(output);

        }
    }
}
