using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModel
{
    public class Permissions
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Type { get; set; }

        public ICollection<Users> Users { get; set; } 
    }
}
