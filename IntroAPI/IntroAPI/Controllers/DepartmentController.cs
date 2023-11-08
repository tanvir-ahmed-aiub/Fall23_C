using IntroAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        [HttpGet]
        [Route("api/departments/all")]
        public HttpResponseMessage GetAll() {
            var db = new DemoF23_CEntities();
            try
            {
                var data = db.Departments.ToList();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex) { 
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/departments/{id}")]
        public HttpResponseMessage Get(int id) {
            var db = new DemoF23_CEntities();
            try {
                var data = db.Departments.Find(id);
                if (data != null) {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else 
                    return Request.CreateResponse(HttpStatusCode.NotFound,new {Msg="No data found" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/departments/create")]
        public HttpResponseMessage Create(Department d) {
            var db = new DemoF23_CEntities();
            try {
                db.Departments.Add(d);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created, new { Msg = "Created" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/departments/update")]
        public HttpResponseMessage Update(Department d) {
            var db = new DemoF23_CEntities();
            try {
                var dept = db.Departments.Find(d.Id);
                db.Entry(dept).CurrentValues.SetValues(d);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, dept);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
