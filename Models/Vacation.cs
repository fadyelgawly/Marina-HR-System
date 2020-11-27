using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MarinaHR.Models
{
    public class Vacation
    {
        public int ID { get; set; }
        
        [Display(Name = "عدد الأيام")]
        public int Days { get; set; }
        
        [Display(Name = "السبب")]
        public string Reason { get; set; }
        
        public Type VacationType { get; set; }

        [Required]
        public string UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        
               
        // [ForeignKey("UserID")]
        // public virtual User User { get; set; }
        
        
    }

    public enum Type {
        Vacation,
        Medical
    }
}