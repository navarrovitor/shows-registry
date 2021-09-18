using System;
using shows_registry.classes;

namespace shows_registry
{
  class Program
  {
    static ShowRepository repository = new ShowRepository();
    static void Main(string[] args)
    {
      string userOption = GetUserOption();

      while (userOption.ToUpper() != "X")
      {
        switch (userOption)
        {
          case "1":
            ListShows();
            break;
          case "2":
            InsertShow();
            break;
          case "3":
            UpdateShow();
            break;
          case "4":
            DeleteShow();
            break;
          case "5":
            ViewShow();
            break;
          case "C":
            Console.Clear();
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }

        userOption = GetUserOption();
      }

      Console.WriteLine("Thank you for visiting!");
      Console.ReadLine();
    }

    private static void DeleteShow()
    {
      Console.Write("What's the show's id? ");
      int showIndex = int.Parse(Console.ReadLine());

      repository.Delete(showIndex);
    }

    private static void ViewShow()
    {
      Console.Write("What's the show's id? ");
      int showIndex = int.Parse(Console.ReadLine());

      var show = repository.ReturnById(showIndex);

      Console.WriteLine(show);
    }

    private static void UpdateShow()
    {
      Console.Write("What's the show's id? ");
      int showIndex = int.Parse(Console.ReadLine());

      foreach (int i in Enum.GetValues(typeof(Genre)))
      {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
      }

      Console.Write("What's the show genre following above options? ");
      int newGenre = int.Parse(Console.ReadLine());

      Console.Write("What's the show title? ");
      string newTitle = Console.ReadLine();

      Console.Write("What's the show year? ");
      int newYear = int.Parse(Console.ReadLine());

      Console.Write("What's the show description? ");
      string newDescription = Console.ReadLine();

      Show newShow = new Show(id: showIndex,
                    genre: (Genre)newGenre,
                    title: newTitle,
                    year: newYear,
                    description: newDescription);

      repository.Update(showIndex, newShow);
    }
    private static void ListShows()
    {
      Console.WriteLine("List shows");

      var list = repository.ShowList();

      if (list.Count == 0)
      {
        Console.WriteLine("No shows registries");
        return;
      }

      foreach (var show in list)
      {
        var deleted = show.returnDeleted();

        Console.WriteLine("#ID {0}: - {1} {2}", show.returnId(), show.returnTitle(), (deleted ? "*Deleted*" : ""));
      }
    }

    private static void InsertShow()
    {
      Console.WriteLine("Insert new show");

      foreach (int i in Enum.GetValues(typeof(Genre)))
      {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
      }
      Console.Write("What's the genre following above options? ");
      int genre = int.Parse(Console.ReadLine());

      Console.Write("What's the show title? ");
      string title = Console.ReadLine();

      Console.Write("What's the show year? ");
      int year = int.Parse(Console.ReadLine());

      Console.Write("What's the show description? ");
      string description = Console.ReadLine();

      Show newShow = new Show(id: repository.NextId(),
                    genre: (Genre)genre,
                    title: title,
                    year: year,
                    description: description);

      repository.Insert(newShow);
    }

    private static string GetUserOption()
    {
      Console.WriteLine();
      Console.WriteLine("What's your option?");

      Console.WriteLine("1- List shows");
      Console.WriteLine("2- Insert new show");
      Console.WriteLine("3- Update a show");
      Console.WriteLine("4- Delete a show");
      Console.WriteLine("5- View show");
      Console.WriteLine("C- Clean screen");
      Console.WriteLine("X- Exit program");
      Console.WriteLine();

      string userOption = Console.ReadLine().ToUpper();
      Console.WriteLine();
      return userOption;
    }
  }
}

