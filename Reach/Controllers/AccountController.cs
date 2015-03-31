using Reach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reach.DAL;
using System.Web.Security;
using Reach.Repository;
using Reach.DTO;

namespace Reach.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        private readonly IRepository<UserProfile> repo = new Repository<UserProfile>();

        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(SignInInput input, string returnUrl)
        {
            using (ReachContext db = new ReachContext())
            {
                if (!ModelState.IsValid)
                {
                    input.Password = null;
                    input.UserName = null;
                    return View(input);
                }

                if (ModelState.IsValid)
                {
                    var user = db.UserProfiles.FirstOrDefault(x => x.UserName == input.UserName && x.Password == input.Password);
                    if (user != null && user.Id > 0)
                    {
                        FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);
                        return RedirectToLocal(returnUrl);
                    }
                }

                ModelState.AddModelError("", "用户名或密码不正确");
                return View(input);
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
            return RedirectToAction("Index", "Account");
        }

    }
}
