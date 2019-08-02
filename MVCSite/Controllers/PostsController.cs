using MVCSite.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSite.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts

        MVCSiteDBEntities db = new MVCSiteDBEntities();
        public ActionResult Index()
        {
            var model = db.Posts.ToList();
            return View(model);
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult PostsUpdate()
        {
            return View();
        }
    }
}