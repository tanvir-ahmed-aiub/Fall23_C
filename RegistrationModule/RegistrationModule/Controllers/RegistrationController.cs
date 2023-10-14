using RegistrationModule.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationModule.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Info()
        {
            var db = new DemoF23_CEntities();
            ViewBag.Courses = db.Courses.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Register(int SId, int[] Courses) {
            var db = new DemoF23_CEntities();
            foreach (var c in Courses) {
                var cs = new CourseStudent() {
                    StId = SId,
                    CId = c,
                    EnrollTime = DateTime.Now
                };
                db.CourseStudents.Add(cs);
            }
            db.SaveChanges();
            return RedirectToAction("Info");
        }
    }
}