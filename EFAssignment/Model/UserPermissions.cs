using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment.Model
{
    public class UserPermissions
    {
        private ICollection<Users> _users;
        private ICollection<Permissions> _permissions;

        public UserPermissions()
        {
            _users = new List<Users>();
            _permissions = new List<Permissions>();
        }

        public int UserId { get; set; }
        public int PermissionId { get; set; }

        public virtual ICollection<Users> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        public virtual ICollection<Permissions> Permissions
        {
            get { return _permissions; }
            set { _permissions = value; }
        }
    }
}
