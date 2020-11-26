using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace MarinaHR.Models
{
    public class Employee : User
    {
        [Display(Name = "الاسم")]
        public string Name { get; set; }
        [Display(Name = "تاريخ الميلاد")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        [Display(Name = "مكان العمل")]
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
}