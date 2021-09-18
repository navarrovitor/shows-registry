using System.Collections.Generic;
using shows_registry.interfaces;

namespace shows_registry.classes
{
  public class ShowRepository : IRepository<Show>
  {
    private List<Show> showList = new List<Show>();
    public void Delete(int id)
    {
      showList[id].Delete();
    }

    public void Insert(Show show)
    {
      showList.Add(show);
    }

    public int NextId()
    {
      return showList.Count;
    }

    public Show ReturnById(int id)
    {
      return showList[id];
    }

    public List<Show> ShowList()
    {
      return showList;
    }

    public void Update(int id, Show show)
    {
      showList[id] = show;
    }
  }
}