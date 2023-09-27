using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutandForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login() {
            //ViewBag.UName = Request["Username"];
            //ViewBag.Password = Request["Password"];
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc) {
            ViewBag.UName = fc["Username"];
            ViewBag.Password = fc["Password"];
            TempData["Msg"] = "Login Successfull";
            //validation
            //authenticate
            //return Redirect("https://www.aiub.edu");
            //return RedirectToAction("Index","Dashboard");
            return View();
        }
    }
}