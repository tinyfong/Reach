using Reach.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reach.Models;

namespace Reach.Controllers
{
    public class BaseVideoController : Controller
    {
        //
        // GET: /BaseVideo/
        protected VideoContext db = new VideoContext();
    
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
