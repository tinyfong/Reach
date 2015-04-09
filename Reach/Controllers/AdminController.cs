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
using Reach.Core;
using Reach.Services;
using PagedList;

namespace Reach.Controllers
{
    [Authorize]
    public class AdminController : CruderController<Video, YoukuVideoInput>
    {
        private readonly IFormsAuthentication formsAuth;
        private readonly IUserService userService;



        public AdminController(ICrudService<Video> service, IMapper<Video, YoukuVideoInput> v, IFormsAuthentication formsAuth, IUserService userService)
            : base(service, v)
        {
            this.formsAuth = formsAuth;
            this.userService = userService;
        }

        public override ActionResult Index()
        {
            return RedirectToAction("Videos", "Admin");
        }

        public ActionResult Videos(int page = 1)
        {
            var pageContent = service.GetAll().ToList().ToPagedList(page, 5);
            ViewBag.VideoList = pageContent;

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
     
        public ActionResult CreateYoukuVideo()
        {
            return View();
        }
    }
}
