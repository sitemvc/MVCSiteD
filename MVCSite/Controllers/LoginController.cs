using MVCSite.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCSite.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login

        MVCSiteDBEntities db = new MVCSiteDBEntities(); 
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]      
        public ActionResult Index(Kullanici kullanici)
        {
            var kullaniciInDB = db.Kullanici.FirstOrDefault(x => x.kullaniciAdi == kullanici.kullaniciAdi && x.parola == kullanici.parola);
            if(kullaniciInDB!=null)
            {
                FormsAuthentication.SetAuthCookie(kullaniciInDB.kullaniciAdi, false);
                return RedirectToAction("Index", "Panel");
            }
            else
            {
                ViewBag.MEsaj = "Geçersiz Kullanıcı Adı veya Parola";
                return View();
            }
            
        }
    }
}