using TheatreShowsAPI.Data;
using TheatreShowsAPI.Models;
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

        private static async Task<IResult> LoadAllShows(
            IShowRepository repository,
            string? title,
            string? genre,

            int? delay)
        {
            var shows = await repository.GetAllAsync();
            var output = shows.ToList();

            if (string.IsNullOrWhiteSpace(title) == false)
            {
                output.RemoveAll(x => x.Title.Contains(title, StringComparison.OrdinalIgnoreCase) == false);
            }

            if (string.IsNullOrWhiteSpace(genre) == false)
            {
                output.RemoveAll(x => x.Genres == null ||
                    !x.Genres.Any(g => g.GenreName.Contains(genre, StringComparison.OrdinalIgnoreCase)));
            }


            if (delay is not null)
            {
                if (delay > 300000)
                {
                    delay = 300000; // Limit delay to 5 minutes
                }
                await Task.Delay((int)delay);
            }

            return Results.Ok(output);
        }

        private static async Task<IResult> LoadShowById(IShowRepository repository, int id, int? delay)
        {
            var output = await repository.GetByIdAsync(id);

            if (delay is not null)
            {
                if (delay > 300000)
                {
                    delay = 300000; // Limit delay to 5 minutes
                }
                await Task.Delay((int)delay);
            }

            if (output is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(output);
        }
    }
}