using RESTfulAPI_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTfulAPI_Project.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductListController : ApiController
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Model = "Mustang", Make = "Ford", Price = 30000.00m },
            new Product { Id = 2, Model = "Challenger", Make = "Dodge", Price = 35000.00m },
            new Product { Id = 3, Model = "Camaro", Make = "Chevrolet", Price = 25000.00m }
        };

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetProducts()
        {
            return Ok(products);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return Ok(product);
        }
    }
}
