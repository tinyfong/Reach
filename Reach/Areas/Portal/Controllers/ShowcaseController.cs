using Reach.Controllers;
using Reach.Core;
using Reach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reach.Areas.Portal.Controllers
{
    public class ShowcaseController : BaseController
    {
        readonly IRepository<Video> repo;

        public ShowcaseController(IRepository<Video> repo)
        {
            this.repo = repo;
        }
        //
        // GET: /Showcase/    
        public ActionResult Index()
        {
            var videoList = repo.GetAll().ToList();
            ViewBag.VideoList = videoList;

            return View();
        }


    }
}
