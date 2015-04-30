using Reach.Core;
using Reach.DAL;
using Reach.Models;
using Reach.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reach.Areas.Portal.Controllers
{
    public class HomeController : Controller
    {

        ReachContext db = new ReachContext();
        readonly IRepository<Video> repo = new Repository<Video>();

        [HttpGet]
        public ActionResult Index(int videoId = 0)
        {
            // Top Video
            Video topVideo = null;
            topVideo = repo.Get(videoId);
            if (topVideo == null)
            {
                topVideo = repo.GetAll().Where(x => x.Rank == 1).OrderByDescending(x => x.CreateDate).FirstOrDefault();
            }
            ViewBag.TopVideo = topVideo;

            // Vedio List
            var videoList = repo.GetAll().Where(x => x.Id != topVideo.Id).Take(4).OrderBy(x => x.Rank).ThenByDescending(x => x.CreateDate).ToList();

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