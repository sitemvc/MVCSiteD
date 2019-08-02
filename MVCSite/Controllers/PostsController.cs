using MVCSite.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCSite.ViewsModel;

namespace MVCSite.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts

        MVCSiteDBEntities db = new MVCSiteDBEntities();
        public ActionResult Index()
        {
            var model = db.Posts.Include(x => x.Categories).ToList();
            return View(model);
        }

        public ActionResult New()
        {
            var model = new PostsFormViewModel()
            {
                Categories = db.Categories.ToList()

            };
            return View("PostsForm",model);
        }

        public ActionResult PostsUpdate()
        {
            return View();
        }
    }
}