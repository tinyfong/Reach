using Reach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Reach.Core
{
    public interface ICrudService<T> where T : Entity, new()
    {
        int Create(T item);
        void Save();
        void Delete(int id);
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Where(Expression<Func<T, bool>> func);     
    }
}