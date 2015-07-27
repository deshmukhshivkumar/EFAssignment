using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModel
{
    public class Helper
    {
        public static List<Users> GetUsers(int number = 1)
        {
            var userList = new List<Users>();
            for (int i = 0; i < number; i++)
            {
                var userType = GetUserType();
                userList.Add(new Users()
                {
                    FirstName = "UserFN" + i,
                    LastName = "LastNM" + i,
                    UserType = userType,
                    Permissions = GetPermission(userType)
                });
            }
            return userList;
        }

        public static UserTypes GetUserType()
        {
            var userType= new UserTypes();

            if (new Random().Next(2000)%2 == 0)
            {
                userType.Name = "Administrator";
            }
            else
            {
                userType.Name = "SuperUser";
            }
            return userType;
        }

        public static List<Permissions> GetPermission(UserTypes userType)
        {
            var permission = new List<Permissions>();

            if (userType.Name == "Administrator")
            {
                permission.Add(new Permissions(){Type = "Add"});
                permission.Add(new Permissions() { Type = "Edit" });
                permission.Add(new Permissions() { Type = "View" });
            }
            else
            {
                permission.Add(new Permissions() { Type = "Read" });                
            }
            return permission;
        }
    }
}
