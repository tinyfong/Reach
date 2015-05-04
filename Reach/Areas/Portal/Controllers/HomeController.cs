using Reach.Controllers;
using Reach.Core;
using Reach.DAL;
using Reach.Models;
using Reach.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reach.DTO;

namespace Reach.Areas.Portal.Controllers
{
    public class HomeController : BaseController
    {
        readonly IRepository<Video> repo;

        public HomeController( IRepository<Video> repo)
        {
            this.repo = repo;
        }


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

            ViewBag.VideoList = videoList;

            return View();

        }
    }
}