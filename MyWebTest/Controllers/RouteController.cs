using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebTest.Controllers
{
    public class RouteController : Controller
    {
        //
        // GET: /Route/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mvc(string postId, string contry, string lang) {
            ViewBag.Contry = contry;
            ViewBag.Lang = lang;
            ViewData["PostID"] = postId;

            return View();
        }

        public ActionResult CrossPostID() {
            ViewData["PostID"] +="...";
            return View();
        }

    }
}
