using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModel
{
    public class UserTypes
    {
        public UserTypes()
        {
            Users = new Collection<Users>();
        }
        [Key]
        public int Id { get; set; }

        [Required]        
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
