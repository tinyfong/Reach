using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reach.DAL;
using Reach.Models;
using Reach.AccessVideoSupplier;
using System.Data.Entity;
using Reach.Repository;
using Reach.Core;

namespace Reach.Controllers
{
    public class HomeController : Controller
    {

        ReachContext db = new ReachContext();
        private readonly IRepository<Video> repo = new Repository<Video>();

        [HttpGet]
        public ActionResult Index(int videoId = 0)
        {
            // Top Video
            Video topVideo = null;
            topVideo = repo.Get(videoId);
            if (topVideo == null)
            {
                topVideo = repo.GetAll().Where(x => x.Rank == 1).OrderByDescending(x => x.UpdateTime).FirstOrDefault();
            }
            ViewBag.TopVideo = topVideo;

            // Vedio List
            var videoList = repo.GetAll().Where(x => x.Id != topVideo.Id).Take(4).OrderBy(x => x.Rank).ThenByDescending(x => x.UpdateTime).ToList();

            // Load Thumbnail
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
