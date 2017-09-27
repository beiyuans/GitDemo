using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        StudentTestEntities1 stu = new StudentTestEntities1();
        // GET: Student
        public ActionResult Index()
        {
            var s = from c in stu.StudentInfo
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
            StudentInfo s = new Models.StudentInfo();
            s.sname = fm["sname"];
            stu.StudentInfo.Add(s);
            stu.Configuration.ValidateOnSaveEnabled = false;
            stu.SaveChanges();//把数据保存到数据库中
            return RedirectToAction("index");
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult delete(int id)
        {
            var d = (from s in stu.StudentInfo
                    where s.sid == id
                    select s).First();
            stu.StudentInfo.Remove((StudentInfo)d);
            //stu.Configuration.ValidateOnSaveEnabled = false;
            stu.SaveChanges();
            return RedirectToAction("index");
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public ActionResult edit(int id, string name)
        {
            var j = stu.StudentInfo.First(c => c.sid == id);
            ViewData["sid"] = j.sid;
            ViewData["sname"] = j.sname;
            return View(j);
        }
        public ActionResult editdata(int sid,string sname)
        {
            var j = stu.StudentInfo .First(c =>c.sid==sid);
            j.sname = sname;
            j.sid = sid;
            stu.SaveChanges();
            return RedirectToAction("index");
        }
    }
}