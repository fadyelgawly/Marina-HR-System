using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MarinaHR.ViewModels
{
public class RegisterViewModel
{
    [Required]
    public string UserName { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    [Compare("Password", ErrorMessage = "Please confirm both passwords are matching")]
    public string ConfirmPassword { get; set; }

    
    
    
    
    
    }
}