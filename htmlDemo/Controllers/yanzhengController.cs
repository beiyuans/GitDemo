using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace htmlDemo.Controllers
{
    public class yanzhengController : Controller
    {
     public static    List<person> lp = new List<person>();
        // GET: yanzheng
        public ActionResult Index()
        {
            return View(lp );
        }
        public ActionResult add()
        {
            return View();
        }
        public ActionResult adddata(person p)
        {
            person pp = new Controllers.person();
            p.name = pp.name;
            p.pwd = pp.pwd;
            lp.Add(pp);
            return RedirectToAction("index");
        }
    }
}