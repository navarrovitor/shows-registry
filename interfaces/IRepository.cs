using System.Collections.Generic;

namespace shows_registry.interfaces
{
  public interface IRepository<T>
  {
    List<T> ShowList();
    T ReturnById(int id);
    void Insert(T entidade);
    void Delete(int id);
    void Update(int id, T entidade);
    int NextId();
  }
}