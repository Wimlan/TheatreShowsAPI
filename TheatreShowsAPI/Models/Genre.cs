using System.Text.Json.Serialization;

namespace TheatreShowsAPI.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }

        [JsonIgnore]
        public ICollection<Show> Shows { get; set; } = new List<Show>();
    }
}
