using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ListController : Controller
    {
        public static List<person> p = new List<person>() {
             new person {id=1,name="zhangsan",address="henan" },
             new person {id=2,name="zhangsan",address="henan" },
         };
           // GET: List
        public ActionResult Index()
        {
           

            return View(p);
        }
        public ActionResult Add()
        {

            return View();
        }
        public ActionResult AddData(int uid,string uname,string uaddress)
        {
            p.Add(new person()
            {
                id = uid,
                name = uname,
                address = uaddress
            });
            return RedirectToAction("index");
        }
        public ActionResult delete(int id)
        {
           var y= p.First(x => x.id == id);
            p.Remove(y);
            return RedirectToAction("index");
        }
        public ActionResult edit(int id)
        {
           var j = p.First(c => c.id == id);
            
            return View (j);

        }
        public ActionResult editdata(int uid,string uname,string uaddress)
        {
            person j = p.First(c => c.id == uid);
            j.name = uname;
            j.address = uaddress;
            return RedirectToAction("index");
        }
    public class person
    {
            public int id { get; set; }
            public string name { get; set; }
            public string address { get; set; }
        }
    }
}