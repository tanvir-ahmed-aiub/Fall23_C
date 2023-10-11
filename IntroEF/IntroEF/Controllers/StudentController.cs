using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var db = new DemoF23_CEntities();
            var data = db.Students.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create() {
            var db = new DemoF23_CEntities();
            ViewBag.Departments = db.Departments.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student) {
            var db = new DemoF23_CEntities();
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}