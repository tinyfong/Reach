using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Reach.Models;

namespace Reach.DAL
{
    public class VideoInitializer : DropCreateDatabaseIfModelChanges<VideoContext>
    {
        protected override void Seed(VideoContext context)
        {
            var videos = new List<Video> { 
            new Video{Id=1}
            };

            videos.ForEach(x => context.Videos.Add(x));
            context.SaveChanges();
        }
    }
}