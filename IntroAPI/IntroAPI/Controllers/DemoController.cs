using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        [Route("api/nums")]
        public HttpResponseMessage GetNums() { 
            var nums = new int[] {1,2,3};
            return Request.CreateResponse(HttpStatusCode.OK, nums);
        }
        [HttpPost]
        [Route("api/test/post")]
        public HttpResponseMessage Post() { 
            return Request.CreateResponse(HttpStatusCode.OK,"Post received");
        }
    }
}
