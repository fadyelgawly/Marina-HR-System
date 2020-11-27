using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarinaHR.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

         public virtual ICollection<User> Users { get; set; }
        
    }
}