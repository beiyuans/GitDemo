using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using login.Models;
using login.Filters;

namespace login.Controllers
{
    
    public class userController : Controller
    {
        
        UserModel um = new UserModel();
        // GET: user
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login( )
        {
            return View();
        }
        public ActionResult loginData(user u)
        {
            var s = um.user.FirstOrDefault(x => x.name == u.name && x.pwd == u.pwd);
            if (s != null)
            {
                Session["uid"] = s.id;
                return RedirectToAction("index");
            }
            else
            return View("login");
        }
    }
}
