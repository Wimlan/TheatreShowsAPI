using System.Text.Json;
using TheatreShowsAPI.Models;

namespace TheatreShowsAPI.Data
{
    public class ShowData
    {
        public List<Show> Shows { get; private set; }

        public ShowData() 
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "showdata.json");
        
        string json = File.ReadAllText(filePath);

            Shows = JsonSerializer.Deserialize<List<Show>>(json, options) ?? new List<Show>();
        }
    }
}
