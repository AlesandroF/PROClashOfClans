using Clash.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Clash.DataBase.Repositories
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(int key)
        {
            return _context.Set<T>().Find(key);
        }

        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            SaveAll();
        }

        public void Update(T obj)
        {
            _context.Set<T>().Update(obj);
            SaveAll();
        }

        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
            SaveAll();
        }

        public void SaveAll()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}