using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace view.Controllers
{
    public class viewController : Controller
    {
        // GET: view
        public ActionResult Index()
        {
            return View();
        }
    }
}