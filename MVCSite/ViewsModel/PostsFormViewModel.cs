using MVCSite.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSite.ViewsModel
{
    public class PostsFormViewModel
    {
        public IEnumerable<Categories> Categories { get; set; }

        public Posts Posts { get; set; }

    }
}