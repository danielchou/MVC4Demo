using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebTest.Filters;

namespace MyWebTest.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Prodution/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult TestGetJson() {
            ProductTyp p = new ProductTyp {
                CreateDate = DateTime.Now,
                Dscr = "For computers.",
                Name = "3C",
                Type = "A001"
            };
            return Json(p);
        }


        [HttpGet]
        public JsonResult TestGetJsonAllowGet() {
            ProductTyp p = new ProductTyp {
                CreateDate = DateTime.Now,
                Dscr = "For computers.",
                Name = "3C",
                Type = "A001"
            };
            //應該避免JSON Hijacking攻擊!
            return Json(p, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult TestOneTypJson(){
            ProductTyp p= new ProductTyp {
                CreateDate = DateTime.Now,
                Dscr = "For computers.",
                Name = "3C",
                Type = "A001"
            };
            return Json(p);
        }

        [HttpPost]
        public JsonResult TestTypsJson() {

            IList<ProductTyp> Typs = new List<ProductTyp>();
            string id="";
            for (int i = 0; i < 10; i++) {
                id=i.ToString();
                ProductTyp p = new ProductTyp {
                    CreateDate = DateTime.Now,
                    Dscr = "For computers.",
                    Name = "3C",
                    Type = "A00"+id
                };
                Typs.Add(p);
            }
            return Json(Typs);
        }

        [HttpPost]
        public JsonDateResult NewJsonDateFormat() {

            IList<ProductTyp> Typs = new List<ProductTyp>();
            string id = "";
            for (int i = 0; i < 10; i++) {
                id = i.ToString();
                ProductTyp p = new ProductTyp {
                    CreateDate = DateTime.Now,
                    Dscr = "For computers.",
                    Name = "3C",
                    Type = "A00" + id
                };
                Typs.Add(p);
            }
            //return Json(Typs);
            return new JsonDateResult() { Data = Typs };
        }

        /// <summary>
        /// 產品型別物件
        /// </summary>
        public class ProductTyp
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string Dscr { get; set; }
            public DateTime CreateDate { get; set; }
        }


        public ActionResult GetAudi() {
            ///應用：
            ///1.想同圖片網址ByUser不同
            ///2.由網址帶參數控制縮放大小控制。
            ///....more
            return File(Server.MapPath("~/App_Data/images/AudiR101.jpg"), "image/jpg");
        }

        public ActionResult RedirectHome() {
            return Redirect("/Home/Index");
        }

        [HttpPost]
        public ActionResult CreatedHttpStatus() {
            ///TODO：假設你這邊建立了資料!
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.Created, "資料已經建立成功!");
        }

    }
}
