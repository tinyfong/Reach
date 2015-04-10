using Reach.Core;
using Reach.DTO;
using Reach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Reach.Controllers.Admin
{

    public class VideosController : CruderController<Video, YoukuVideoInput>
    {
        //
        // GET: /Login/

        public VideosController(ICrudService<Video> service, IMapper<Video, YoukuVideoInput> v)
            : base(service, v)
        {

        }
               

        public override ActionResult Index()
        {
            int page = 1;
            var pageContent = service.GetAll().ToList().ToPagedList(page, 5);
            ViewBag.VideoList = pageContent;

            return View();
        }
    }
}
