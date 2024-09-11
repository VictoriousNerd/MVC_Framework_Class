using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CURDOppMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter the employee number")]
        [DisplayName("Employee Number")]
        public string EmpNo { get; set; }
        [Required(ErrorMessage = "Please enter the employee fisrt name")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter the employee last name")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter the employee email")]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter the employee mobile number")]
        [DisplayName("Mobile Number")]
        public string MobileNo { get; set; }
    }
}