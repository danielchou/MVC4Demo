using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebTest.Controllers
{
    public class RazorController : Controller
    {
        //
        // GET: /Razor/

        public ActionResult Index()
        {
            return View();
        }

        public static int CalculateMe() {
            int i=2000;
            return i;
        }
    }
}
