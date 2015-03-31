using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reach.Models;
using Reach.DAL;
using System.Linq.Expressions;
using Reach.Core;

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
            return db.Set<T>().Where(predicate);
        }

        public T Insert(T o)
        {
            var t = db.Set<T>().Create();
            t.Id = o.Id;
            db.Set<T>().Add(t);
            return t;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Delete(T o)
        {
            db.Set<T>().Remove(o);
        }
    }
}