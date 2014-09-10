using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebTest.Controllers
{
    public class BindModelController : Controller
    {
        //
        // GET: /BindModel/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(User u) {
            //string Name = u.Name;
            //string Email = u.Email;
            //int Ate = u.Age;        //會自動轉型!!

            return View(u);                     //直接Model物件就傳進去了!!
            //return RedirectToAction("Error");    //如果邏輯有錯，可在Action階段就轉出去。
        }


    }

    /// <summary>
    /// 這邊算是Model類別物件，應該切出檔案分到Models目錄下才對!!
    /// </summary>
    public class User {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
