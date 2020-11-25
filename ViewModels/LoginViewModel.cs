using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarinaHR.ViewModels
{
    public class LoginViewModel
    {

            [EmailAddress]
            [MaxLength(50), MinLength(7)]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [MaxLength(100), MinLength(4)]
            public string Password { get; set; }

            [Display(Name = "Remember Me?")]
            public bool RememberMe { get; set; }
    }
}