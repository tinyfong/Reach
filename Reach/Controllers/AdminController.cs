using Reach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reach.DAL;
using System.Web.Security;

namespace Reach.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Login(UserProfile model, string returnUrl)
        {
            using (ReachContext db = new ReachContext())
            {
                if (ModelState.IsValid)
                {
                    var user = db.UserProfiles.FirstOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);
                    if (user != null && user.Id > 0)
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                        return RedirectToLocal(returnUrl);
                    }
                }

                ModelState.AddModelError("", "用户名或密码不正确");
                return View(model);
            }
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
            return RedirectToAction("Index", "Admin");
        }
    }
}
