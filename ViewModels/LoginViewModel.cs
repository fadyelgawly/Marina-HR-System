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
        [Required]
        [Display(Name = "اسم المستخدم")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "كلمه السر")]
        [DataType(DataType.Password)]
        [MaxLength(100), MinLength(4)]
        public string Password { get; set; }
        [Display(Name = "حفظ المستخدم")]
        public bool RememberMe { get; set; }
    }
}