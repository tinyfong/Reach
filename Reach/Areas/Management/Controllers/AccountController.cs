using Reach.Core;
using Reach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reach.Areas.Management.Controllers
{

    public class AccountController : BaseController
    {
        private readonly IFormsAuthentication formsAuth;
        private readonly IUserService userService;

        public AccountController(IFormsAuthentication formsAuth, IUserService userService)
        {
            this.formsAuth = formsAuth;
            this.userService = userService;
        }

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult LoginIn(SignInInput input, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                input.Password = null;

                return View(input);
            }

            var user = userService.Get(input.UserName, input.Password);
            if (user == null)
            {
                ModelState.AddModelError("", "用户名或密码不正确");
                return View(input);
            }

            formsAuth.SignIn(user.UserName, input.RememberMe, user.Roles.Select(x => x.Name));
            return RedirectToLocal(returnUrl);
        }

        public ActionResult LoginOut()
        {
            formsAuth.SignOut();
            return RedirectToAction("Login");
        }

    }
}
