using System;

namespace shows_registry
{
  public class Show : BaseEntity
  {
    private Genre Genre { get; set; }
    private string Title { get; set; }
    private string Description { get; set; }
    private int Year { get; set; }
    private bool Erasen { get; set; }
    public Show(int id, Genre genre, string title, string description, int year)
    {
      this.Id = id;
      this.Genre = genre;
      this.Title = title;
      this.Description = description;
      this.Year = year;
      this.Erasen = false;
    }

    public override string ToString()
    {
      string returnMessage = "";
      returnMessage += "Genre: " + this.Genre + Environment.NewLine;
      returnMessage += "Title: " + this.Title + Environment.NewLine;
      returnMessage += "Description: " + this.Description + Environment.NewLine;
      returnMessage += "Year: " + this.Year + Environment.NewLine;
      returnMessage += "Erasen: " + this.Erasen;
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

    public bool returnErasen()
    {
      return this.Erasen;
    }
    public void Erase()
    {
      this.Erasen = true;
    }

  }
}