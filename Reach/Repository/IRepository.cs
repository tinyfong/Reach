using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Reach.Repository
{
    public interface IRepository<T>
    {
        T Get(int id);

        IQueryable<T> GetAll();

        IQueryable<T> Where(Expression<Func<T, bool>> predicate);

        T Insert(T o);

        void Save();

        void Delete(T o);

    }
}