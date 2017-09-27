using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace htmlDemo.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult add(int id,string name, int age)
        {
            return Content("姓名：" + name + "编号" + id + "年龄：" + age);
        }
        public ActionResult add1( string name, string  pwd)
        {
            return Content("姓名：" + name + "密码："+pwd);
        }
    }
}