namespace TheatreShowsAPI.Models
{
    public class Show
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? SubHeading { get; set; }
        public string? Description { get; set; }
        public string? Venue { get; set; }
        public int? YearPublished { get; set; }
        public string? Trailer { get; set; }
        public string? Image { get; set; }

        public ICollection<Genre> Genres { get; set; } = new List<Genre>();
        public ICollection<ProductionMember> ProductionMembers { get; set; } = new List<ProductionMember>();

    }





}
