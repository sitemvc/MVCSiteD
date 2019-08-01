﻿using MVCSite.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSite.Controllers
{
    public class PanelController : Controller
    {
        // GET: Panel
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

    }
}