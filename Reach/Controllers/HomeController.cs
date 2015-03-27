using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reach.DAL;
using Reach.Models;
using Reach.AccessVideoSupplier;
using System.Data.Entity;

namespace Reach.Controllers
{
    public class HomeController : Controller
    {
        ReachContext db = new ReachContext();

        [HttpGet]
        public ActionResult Index(int videoId = 0)
        {
            // Top Video
            Video topVideo = null;
            topVideo = db.Set<Video>().Find(videoId);
            if (topVideo == null)
            {
                topVideo = db.Set<Video>().Where(x => x.Rank == 1).OrderByDescending(x => x.UpdateTime).FirstOrDefault();
            }
            ViewBag.TopVideo = topVideo;

            // Vedio List
            var videoList = db.Set<Video>().Where(x => x.Id != topVideo.Id).OrderBy(x => x.Rank).ThenByDescending(x => x.UpdateTime).ToList();
            YoukuThumbnailHandler handler = new YoukuThumbnailHandler();
            foreach (var item in videoList)
            {
                if (item.BigThumbnail == null)
                {
                    var image = handler.GetBigThumbnailByYoukuId(item.YoukuId);
                    item.BigThumbnail = image;
                    db.Entry<Video>(item).State = EntityState.Modified;
                }
                if (item.Thumbnail == null)
                {
                    var image = handler.GetThumbnailByYoukuId(item.YoukuId);
                    item.Thumbnail = image;
                    db.Entry<Video>(item).State = EntityState.Modified;
                }
            }

            db.SaveChanges();

            ViewBag.VideoList = videoList;

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
