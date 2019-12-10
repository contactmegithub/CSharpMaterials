using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMVCApplication.Models
{
    public class Login
    {
        [Required(ErrorMessage ="User name should not be empty")]
        [MinLength(length:4, ErrorMessage ="Min 4 char")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password should not be empty")]
        [RegularExpression(pattern: @"^(?=(.*\d){2})(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z\d]).{8,}$",
            ErrorMessage = @"Pattern not mathced Requirement :

At least 8 characters long
2 letters
2 digits
1 Upper case
1 Lower case
1 Symbol")]
        public string Password { get; set; }
    }
}