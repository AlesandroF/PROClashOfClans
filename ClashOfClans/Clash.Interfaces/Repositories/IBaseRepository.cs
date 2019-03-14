using System.Collections.Generic;

namespace Clash.Interfaces.Repositories
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int key);
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        void SaveAll();
    }
}