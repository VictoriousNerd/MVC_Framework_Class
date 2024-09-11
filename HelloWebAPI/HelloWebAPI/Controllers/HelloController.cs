using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebAPI.Controllers
{
    public class HelloController : ApiController
    {
        [HttpGet]
        public IHttpActionResult HelloWorld()
        {
            return Ok("Hello world web api");
        }


        [HttpGet]
        public IHttpActionResult HelloWorldName(string name)
        {
            return Ok("Hello world web api "+name);
        }
    }
}
