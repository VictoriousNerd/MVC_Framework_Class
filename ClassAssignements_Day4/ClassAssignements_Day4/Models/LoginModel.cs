using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClassAssignements_Day4.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please Enter User Name")]

        [Display(Name = "User Name")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]

        [DataType(DataType.Password)]

        public string Password { get; set; }
    }
}