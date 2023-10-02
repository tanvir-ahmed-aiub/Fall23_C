using LayoutandForm.Models;
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
        //public ActionResult Login(FormCollection fc) {
        //public ActionResult Login(string Username, string Password) {
        public ActionResult Login(LoginModel login) {

            //ViewBag.UName = fc["Username"];
            //ViewBag.Password = fc["Password"];
            //TempData["Msg"] = "Login Successfull";
            //validation
            //authenticate
            //return Redirect("https://www.aiub.edu");
            //return RedirectToAction("Index","Dashboard");
            return View(login);
        }

        [HttpGet]
        public ActionResult SignUp() { 
            return View() ;
        }
        [HttpPost]
        public ActionResult SignUp(SignUpModel singUp) {
            if (ModelState.IsValid) {
                return RedirectToAction("Index");  
            }
            return View(singUp);
        }
    }
}