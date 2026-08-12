using System.Text.Json.Serialization;

namespace TheatreShowsAPI.Models
{
    public class ProductionMember
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public ICollection<Show> Shows { get; set; } = new List<Show>();
    }
}
