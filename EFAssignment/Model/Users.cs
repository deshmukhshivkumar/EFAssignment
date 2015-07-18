using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment.Model
{
    public class Users
    {
        private ICollection<UserTypes> _userTypes;
        
        public Users()
        {
            _userTypes = new List<UserTypes>();
        }
        
        [Key]
        public int Id { get; set; }
        //[Column(DbType = "NVarChar(50) NOT NULL")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("UserTypes")]
        public int UserTypeId { get; set; }

        public virtual ICollection<UserTypes> UserTypes
        {
            get { return _userTypes; }
            set { _userTypes = value; }
        }
    }
}
