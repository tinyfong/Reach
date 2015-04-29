using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reach.Core;
using Reach.Models;

namespace Reach.Services
{
    public class VideoService : CrudService<Video>
    {
        public override int Create(Video item)
        {
            item.CreateDate = DateTime.Now;
            return base.Create(item);
        }
    }
}