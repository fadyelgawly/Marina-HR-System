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

        [Display(Name = "السبب")]
        public string Reason { get; set; }

        public Type VacationType { get; set; }

        [Display(Name = "من")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "إلى")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public Status VacationStatus { get; set; } = Status.Requested;

        [Required]
        public string UserID { get; set; }
        
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        
    }

    public enum Type {
        Vacation,
        Medical
    }
        public enum Status {
        Requested,
        Accepted,
        Declined
    }
}