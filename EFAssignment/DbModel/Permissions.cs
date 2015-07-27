using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DbModel
{
    public class Permissions
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

        public ICollection<Users> Users { get; set; } 
    }
}
