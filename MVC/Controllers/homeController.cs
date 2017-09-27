using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult two()
        {
            return Content("大三开始了");
        }
        public ActionResult test()
        {
            return RedirectToAction("Test", "index");
        }
        public ActionResult js()
        {
            person p = new person()
            {
            id = 1,
            name="zhangsan",
            adress="河南"
            };
            return Json(p, JsonRequestBehavior.AllowGet);
        }
    }
    public class person{
        public int id { get; set; }
        public string  name { get; set; }
        public string  adress { get; set; }
    }
}