using Reach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reach.Areas.Portal.Controllers
{
    public class ShowcaseController : BaseVideoController
    {
        //
        // GET: /Showcase/    
        public ActionResult Index()
        {
            var videoList = db.Set<Video>().ToList();
            ViewBag.VideoList = videoList;

            return View();
        }


    }
}
