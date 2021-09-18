namespace shows_registry
{
    public class Show : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
    }

    public Show(int id, Genre genre, string title, string description, int year) 
    {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
    }
    
}