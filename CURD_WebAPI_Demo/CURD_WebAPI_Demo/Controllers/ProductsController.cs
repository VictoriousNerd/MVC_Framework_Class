using CURD_WebAPI_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CURD_WebAPI_Demo.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Make = "Ford", Model = "Mustang"},
            new Product { Id = 2, Make = "Dodge", Model = "Challenger"}
        };

        // Get
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(products);
        }

        // Get by Id
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // Post
        [HttpPost]
        public HttpResponseMessage Create(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            var response = Request.CreateResponse(HttpStatusCode.Created, product);
            return response;
        }

        // Put
        [HttpPut]
        public IHttpActionResult Update(int id, Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            existingProduct.Make = product.Make;
            existingProduct.Model = product.Model;
            return Ok(existingProduct);
        }

        // Delete
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            products.Remove(product);
            return Ok(product);
        }
    }
}
