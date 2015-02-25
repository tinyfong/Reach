using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reach.Repository.Repositories
{
    public class VideoRepository : BaseRepository<Video>
    {
        public Video GetById()
        {
            return this.Select(1);
        }
        public List<Video> SelectRecent()
        {
            using (ReachContainer db = new ReachContainer())
            {
                List<Video> list = db.Set<Video>().OrderBy(x => x.Rank).ThenByDescending(x => x.UpdateTime).Take(5).ToList();
                return list;
            }
        }

    }
}
