using System;
using System.Collections.Generic;

namespace DbModel
{
    public class Helper
    {
        public const string Administrator = "Administrator";
        public const string SuperUser = "SuperUser";
        public const string DataEntryOperator = "Data Entry Operator";
        public const string AgentUser = "Agent User";
        public const string CustomerUser = "Customer User";
        public const string Operator = "Operator";

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
            var userType = new UserTypes();

            switch (new Random().Next(2000) % 4)
            {
                case 0:
                    userType.Name = Administrator;
                    break;
                case 1:
                    userType.Name = SuperUser;
                    break;
                case 2:
                    userType.Name = DataEntryOperator;
                    break;
                case 3:
                    userType.Name = AgentUser;
                    break;
                case 4:
                    userType.Name = CustomerUser;
                    break;
                default:
                    userType.Name = Operator;
                    break;
            }

            return userType;
        }

        public static List<Permissions> GetPermission(UserTypes userType)
        {
            var permission = new List<Permissions>();

            switch (userType.Name)
            {
                case Administrator:
                        permission.Add(new Permissions(){Type = "Add"});
                        permission.Add(new Permissions() { Type = "Edit" });
                        permission.Add(new Permissions() { Type = "View" });
                        permission.Add(new Permissions() { Type = "Read" });
                        permission.Add(new Permissions() { Type = "Execute" });
                        permission.Add(new Permissions() { Type = "Modify" });
                        permission.Add(new Permissions() { Type = "Delete" });
                        permission.Add(new Permissions() { Type = "Send" });
                        permission.Add(new Permissions() { Type = "Update" });
                        permission.Add(new Permissions() {Type = "All"});
                    break;
                case SuperUser:
                    permission.Add(new Permissions(){Type = "Add"});
                        permission.Add(new Permissions() { Type = "Edit" });
                        permission.Add(new Permissions() { Type = "View" });
                        permission.Add(new Permissions() { Type = "Read" });
                        permission.Add(new Permissions() { Type = "Execute" });
                        permission.Add(new Permissions() { Type = "Modify" });
                    break;
                case DataEntryOperator:
                     permission.Add(new Permissions() { Type = "Read" });
                        permission.Add(new Permissions() { Type = "Execute" });
                        permission.Add(new Permissions() { Type = "Modify" });
                        permission.Add(new Permissions() { Type = "Delete" });
                        permission.Add(new Permissions() { Type = "Send" });
                        permission.Add(new Permissions() { Type = "Update" });
                        permission.Add(new Permissions() {Type = "All"});
                    break;
                case AgentUser:
                        permission.Add(new Permissions() { Type = "Edit" });
                        permission.Add(new Permissions() { Type = "View" });
                        permission.Add(new Permissions() { Type = "Update" });
                        permission.Add(new Permissions() {Type = "All"});
                    break;
                case CustomerUser:
                        permission.Add(new Permissions() { Type = "Execute" });
                        permission.Add(new Permissions() { Type = "Modify" });
                        permission.Add(new Permissions() { Type = "Delete" });
                    break;
                case Operator:
                        permission.Add(new Permissions() { Type = "Edit" });
                        permission.Add(new Permissions() { Type = "View" });
                        permission.Add(new Permissions() { Type = "Read" });                        
                    break;
                default:
                        permission.Add(new Permissions() { Type = "Read" });                        
                    break;                    
            }
            return permission;
        }
    }
}
