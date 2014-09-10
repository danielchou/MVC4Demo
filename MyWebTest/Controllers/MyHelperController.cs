using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebTest.Controllers
{
    public class MyHelperController : Controller
    {
        //
        // GET: /WebHelper/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RenderPartial() {
            return View();
        }
    }
}
