using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTfulAPI_Project.Controllers
{
    public class HelloWorldController : ApiController
    {
        [HttpGet]
        [Route("api/helloworld/welcome/{name}")]
        public IHttpActionResult Welcome(string name)
        {
            string message = $"Hello World! Welcome, {name}!";
            return Ok(message);
        }
    }
}
