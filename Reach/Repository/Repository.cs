using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reach.Models;
using Reach.DAL;
using System.Linq.Expressions;

namespace Reach.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly ReachContext db;

        public Repository()
        {
            db = new ReachContext();
        }

        public T Get(int id)
        {
            var entity = db.Set<T>().Find(id);
            return entity;
        }

        public virtual IQueryable<T> GetAll()
        {
            return db.Set<T>();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Insert(T o)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Delete(T o)
        {
            throw new NotImplementedException();
        }
    }
}