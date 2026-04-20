namespace SampleTestUI.Models
{
    public class ShowModel
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string ShowType { get; set; }
        public required string Venue { get; set; }
        public int YearPublished { get; set; }
        public required string Image { get; set; }
    }
}
