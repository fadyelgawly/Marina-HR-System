using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarinaHR.Models
{
    public class Vacation
    {
        public int ID { get; set; }
        
        public int Days { get; set; }
        
        public string Reason { get; set; }
        
        public Type VacationType { get; set; }
        
        
        
    }

    public enum Type {
        Vacation,
        Medical
    }
}