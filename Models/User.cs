using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MarinaHR.Models
{
    public class User : IdentityUser
    {
        [Display(Name = "الاسم")]
        public string Name { get; set; }
        [Display(Name = "تاريخ الميلاد")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        [Display(Name = "مكان العمل")]
        public SalaryFrequency SalaryType { get; set; }
        public double SalaryAmount { get; set; }
        [Display(Name = "رصيد الإجازة")]
        public int VacationBalance { get; set; } = 21;
        public int PlaceID { get; set; }
        [Display(Name = "القسم")]
        public int DepartmentID { get; set; }
        [Display(Name = "مكان العمل")]
        [ForeignKey("PlaceID")]
        public virtual Place Place { get; set; }
        [Display(Name = "القسم")]
        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }



        
        
    }

    public enum SalaryFrequency {
        Weekly,
        Monthly
    }

    public class SMSBody
    {
        public string Body { get; set; }
    }



}