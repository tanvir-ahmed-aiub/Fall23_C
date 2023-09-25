

using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            Company c = new Company();
            c.Name = "Abc Company";
            c.Address = "Dhaka";
            c.Email = "tanvir.ahmed@aiub.edu";
            c.Descr = "demo";
            Person p = new Person();
            p.Name = "tanvir";
            p.Email = "tanvir.ahmed@aiub.edu";
            p.Address = "aiub";
            p.Descr = "FST,CS,AIUB";


            return View(c);
        }
        public ActionResult Projects() {
            var p1 = new Project() { 
                Name = "p1",
                Client = "c1"
            };

            var p2 = new Project() { 
                Name="p2",
                Client = "c2"
            };

            var projects = new Project[] { p1, p2 };
            return View(projects);
        }
        public ActionResult Teams() {
            return View();
        }
    }
}