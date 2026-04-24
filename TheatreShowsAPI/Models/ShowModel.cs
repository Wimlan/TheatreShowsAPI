namespace TheatreShowsAPI.Models
{
    public class ShowModel
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string SubHeading { get; set; }

        // JSON contains arrays -> use List<string>
        public required string Description { get; set; }
        public List<string> ShowType { get; set; } = new();

        public required string Venue { get; set; }
        public int YearPublished { get; set; }

        // ProductionMembers is an array of objects with single property names
        // Use a flexible type or create a typed model for clarity
        public List<Dictionary<string, List<string>>> ProductionMembers { get; set; } = new();

        public required string Trailer { get; set; }
        public required string Image { get; set; }

    }





}
