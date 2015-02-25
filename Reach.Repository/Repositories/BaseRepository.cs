using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reach.Repository.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository where T : IBaseEntity
    {
        public T Select(int id)
        {
            using (ReachContainer db = new ReachContainer())
            {
                T entity = db.Set<T>().Where(x => x.Id == id).FirstOrDefault();
                return entity;
            }
        }
             


    }
}
