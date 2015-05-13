using Reach.Controllers;
using Reach.Core;
using Reach.DTO;
using Reach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Reach.Areas.Management.Controllers
{

    public class HomeController : CruderController<WebsiteInfo, WebsiteInfoInput>
    {

        public HomeController(ICrudService<WebsiteInfo> service, IMapper<WebsiteInfo, WebsiteInfoInput> v)
            : base(service, v)
        {

        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Videos");
        }


        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return DefaultAction();
            }
        }

        private ActionResult DefaultAction()
        {
            return RedirectToAction("Index", "Home");
        }


        public ActionResult CreateYoukuVideo()
        {
            return View();
        }


        public ActionResult ViewLyubomir()
        {
            return PartialView("_Lyubomir");
        }

        [HttpPost]
        public ActionResult Lyubomir()
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactUs(WebsiteInfoInput input)
        {
            return View();
        }
    }
}
