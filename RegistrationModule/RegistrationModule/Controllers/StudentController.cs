using AutoMapper;
using RegistrationModule.DTOs;
using RegistrationModule.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationModule.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var db = new DemoF23_CEntities();
            var data = db.Students.ToList();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Student,StudentDTO>();
            });
            var mapper = new Mapper(config);
            var data2 = mapper.Map<List<StudentDTO>>(data);

            return View(Convert(data));
        }
        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentDTO s) {
            if (ModelState.IsValid)
            {
                #region
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<StudentDTO,Student>();
                });
                var mapper = new Mapper(config);
                var data = mapper.Map<Student>(s);
                #endregion
                var db = new DemoF23_CEntities();
                db.Students.Add(Convert(s));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(s);
        }
        StudentDTO Convert(Student s)
        {
            return new StudentDTO() { 
                Id = s.Id,
                Name = s.Name,
                DeptId = s.DeptId,
                Cgpa = s.Cgpa
            };
        }
        Student Convert(StudentDTO s) {
            return new Student() {
                Id = s.Id,
                Name = s.Name,
                DeptId = s.DeptId,
                Cgpa = s.Cgpa
            };
        }
        List<StudentDTO> Convert(List<Student> s) { 
            var list = new List<StudentDTO>();
            foreach (var st in s) { 
                list.Add(Convert(st));
            }
            return list;
        }
    }
    
}