using System.Text.Json;
using TheatreShowsAPI.Models;

namespace TheatreShowsAPI.Data
{
    public class ShowData
    {
        public List<ShowModel> Shows { get; private set; }

        public ShowData() 
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "showdata.json");
        
        string json = File.ReadAllText(filePath);

            Shows = JsonSerializer.Deserialize<List<ShowModel>>(json, options) ?? new List<ShowModel>();
        }
    }
}
