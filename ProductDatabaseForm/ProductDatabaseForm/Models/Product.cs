using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProductDatabaseForm.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the Product number")]
        [DisplayName("Product Number")]
        public string ProductNo { get; set; }
        [Required(ErrorMessage = "Please enter the Product name")]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the Product category")]
        [DisplayName("Product Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter the Product price")]
        [DisplayName("Product Price")]
        public string Price { get; set; }
    }
}