using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zaratEngineering.Controllers
{
    public class HomeController : Controller
    {
        public static zaratEngineering.Models.WishItemImage model = 
            new zaratEngineering.Models.WishItemImage();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contacts()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult myWishList()
        {
            return View(model);
        }

        public ActionResult FullImage(String path)
        {
            return View(model);
        }

        public ActionResult javeWL()
        {
            return View(model);
        }        
    }
}