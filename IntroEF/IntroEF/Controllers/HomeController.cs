using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new DemoF23_CEntities();
            var data = db.Departments.ToList();
            return View(data);
        }
        public ActionResult Details(int id) { 
            var db = new DemoF23_CEntities();
            var dept = db.Departments.Find(id);
            //ViewBag.Courses = (from c in db.Courses
            //                   where c.DeptId == id
            //                   select c).ToList();
            //ViewBag.Students = (from c in db.Students
            //                   where c.DeptId == id
            //                   select c).ToList();

            return View(dept);
        }
        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department d) {
            var db = new DemoF23_CEntities();
            db.Departments.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Edit(int id) {
            var db = new DemoF23_CEntities();
            var ex = (from d in db.Departments
                     where d.Id == id
                     select d).SingleOrDefault();
            return View(ex);

        }
        [HttpPost]
        public ActionResult Edit(Department d) {
            var db = new DemoF23_CEntities();
            var exdata = db.Departments.Find(d.Id);
            exdata.Name = d.Name;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id) {
            var db = new DemoF23_CEntities();
            var exdata = db.Departments.Find(id);
            db.Departments.Remove(exdata);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}