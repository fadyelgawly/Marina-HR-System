using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MarinaHR.ViewModels
{
    public class CreateUserViewModel
    {
        
        [Display(Name = "وظيفة")]
        public string RoleID { get; set; }

        [Display(Name = "مكان العمل")]
        public int PlaceID { get; set; }

        [Display(Name = "القسم")]
        public int DepartmentID { get; set; }

        [Display(Name = "اسم المستخدم")]
        public string UserName { get; set; }

        [Display(Name = "الاسم")]
        public string Name { get; set; }

        [Display(Name = "تاريخ الميلاد")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Display(Name = "رقم الهاتف")]
        public string PhoneNumber { get; set; }


    }
}