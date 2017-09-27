using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult data()
        {
            ViewData["h"] = "hello";
            ViewBag.w = "word";
            return View();
        }
        public ActionResult h()
        {
            List<person> p = new List<person>();
            p.Add(new person()
            {
                id=1,
                name="zhangsan",
                address="henan",
            });
            p.Add(new person()
            {
                id = 2,
                name = "lisi",
                address = "henn",
            });

            return View(p);
        }
  public class person{
    public int id { get; set; }
        public string name { get; set; }
            public string  address { get;  set; }
        }
    }
  
}