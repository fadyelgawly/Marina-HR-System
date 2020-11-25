using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace MarinaHR.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int PlaceID { get; set; }    
        public int DepartmentID { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
        
        

        [ForeignKey("PlaceID")]
        public virtual Place Place { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }
        
        
    }
}