using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
namespace MVC.Controllers
{
    public class CoureController : Controller
    {
        StudentTestEntities1 stu = new StudentTestEntities1();
        // GET: Coure
        public ActionResult Index()
        {
            var  s = from c in stu.Course
                            select c;
            return View(s);
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
       public ActionResult add()
        {
            return View();
        }
        public ActionResult adddata(FormCollection fm)
        {
            Course c = new Course();
            c.cname = fm["name"];
            stu.Course.Add(c);
            //stu.Configuration.ValidateOnSaveEnabled = false;
            stu.SaveChanges();
            return RedirectToAction("index");
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult delete(int id)
        {
            var d = (from dd in stu.Course
                     where dd.cid == id
                     select dd).First();
            stu.Course.Remove(d);
            stu.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult edit(int id, string name)
        {
            var a = (from dd in stu.Course
                     where dd.cid == id
                     select dd).First();
            ViewData["cname"] =a.cname;
            ViewData["cid"] = a.cid;
            return View(a);
           
        }
        public ActionResult editdata(int cid,string cname)
        {
            var a = (from dd in stu.Course
                     where dd.cid == cid
                     select dd).First();
            a.cid = cid;
            a.cname = cname;
            //stu.Configuration.ValidateOnSaveEnabled = false;
            stu.SaveChanges();
            return RedirectToAction("index");
        }
    }
}