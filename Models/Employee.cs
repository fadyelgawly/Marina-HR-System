using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace MarinaHR.Models
{
    public class Employee : User
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int PlaceID { get; set; }    
        public int DepartmentID { get; set; }

        [ForeignKey("PlaceID")]
        public virtual Place Place { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }
        
        
    }
}