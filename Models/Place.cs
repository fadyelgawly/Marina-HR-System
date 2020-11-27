using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarinaHR.Models
{
    public class Place
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<User> Users { get; set; }
        
        
        
    }
}