using System;

namespace shows_registry
{
  public class Show : BaseEntity
  {
    private Genre Genre { get; set; }
    private string Title { get; set; }
    private string Description { get; set; }
    private int Year { get; set; }
    private bool Deleted { get; set; }
    public Show(int id, Genre genre, string title, string description, int year)
    {
      this.Id = id;
      this.Genre = genre;
      this.Title = title;
      this.Description = description;
      this.Year = year;
      this.Deleted = false;
    }

    public override string ToString()
    {
      string returnMessage = "";
      returnMessage += "Genre: " + this.Genre + Environment.NewLine;
      returnMessage += "Title: " + this.Title + Environment.NewLine;
      returnMessage += "Description: " + this.Description + Environment.NewLine;
      returnMessage += "Year: " + this.Year + Environment.NewLine;
      returnMessage += "Deleted: " + this.Deleted;
      return returnMessage;
    }

    public int returnId()
    {
      return this.Id;
    }

    public string returnTitle()
    {
      return this.Title;
    }

    public bool returnDeleted()
    {
      return this.Deleted;
    }
    public void Delete()
    {
      this.Deleted = true;
    }

  }
}