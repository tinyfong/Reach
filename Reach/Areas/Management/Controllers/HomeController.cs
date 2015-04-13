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
    [ManagementAuthorizeAttribute]
    public class HomeController : CruderController<Video, YoukuVideoInput>
    {

        public HomeController(ICrudService<Video> service, IMapper<Video, YoukuVideoInput> v)
            : base(service, v)
        {

        }

        public  ActionResult Index()
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
    }
}
