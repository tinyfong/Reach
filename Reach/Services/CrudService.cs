using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reach.Core;
using Reach.Models;
using Reach.Repository;
using System.Linq.Expressions;

namespace Reach.Services
{
    public class CrudService<T> : ICrudService<T> where T : Entity, new()
    {
        protected IRepository<T> repo;
        public CrudService()
        {
            repo = new Repository<T>();
        }

        public virtual int Create(T item)
        {
            var newItem = repo.Insert(item);
            repo.Save();
            return newItem.Id;
        }

        public  void Save()
        {
            repo.Save();
        }

        public virtual void Delete(int id)
        {
            repo.Delete(repo.Get(id));
            repo.Save();
        }

        public T Get(int id)
        {
            return repo.Get(id);
        }

        public IEnumerable<T> GetAll()
        {
            return repo.GetAll();
        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> func)
        {
            return repo.Where(func);
        }
    }
}