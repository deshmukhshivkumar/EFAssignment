using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DbModel
{
    public class Users
    {
        public Users()
        {
            Permissions = new Collection<Permissions>();
        }

        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]        
        [Required]
        public string LastName { get; set; }

        public int? UserTypeId { get; set; }

        public UserTypes UserType { get; set; }

        public ICollection<Permissions> Permissions { get; set; }
    }
}
