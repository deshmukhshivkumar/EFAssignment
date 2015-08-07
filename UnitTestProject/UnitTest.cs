
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DbModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Read_Users_Top10()
        {
            using (var db = new UserDbContext())
            {
                var users = db.Users.Take(10).ToList();

                Assert.AreEqual(10, users.Count);

                foreach (var user in users)
                {
                    Assert.IsNotNull(user.FirstName);
                }
            }
        }


        [TestMethod]
        public void Update_UserType()
        {
            using (var db = new UserDbContext())
            {
                var users = db.Users.Take(10).ToList();

                Assert.AreEqual(10, users.Count);

                for (int i = 0; i < 10; i++)
                {
                    if (i == 9)
                        users[i].UserTypeId = users[0].UserTypeId;
                    else
                        users[i].UserTypeId = users[i + 1].UserTypeId;
                }

                var userIdUserTypeIdMapping = new Dictionary<int, int>();

                foreach (var user in users)
                {
                    if (user.UserTypeId != null)
                        userIdUserTypeIdMapping.Add(user.Id, (int)user.UserTypeId);
                }
                db.SaveChanges();

                var updatedUsers = db.Users.Take(10).ToList();

                Assert.AreEqual(10, users.Count);

                foreach (var user in updatedUsers)
                {
                    int userTypeId = -1;
                    userIdUserTypeIdMapping.TryGetValue(user.Id, out userTypeId);

                    Assert.IsTrue(userTypeId != -1);


                    Assert.AreEqual(userTypeId, user.UserTypeId);
                }

            }
        }

        [TestMethod]
        public void Insert_UserPermissions()
        {
            using (var db = new UserDbContext())
            {
                var users = db.Users.Take(10).ToList();

                Assert.AreEqual(10, users.Count);

                foreach (var user in users)
                {
                    Assert.IsNotNull(user.FirstName);
                }

                for (int i = 0; i < 10; i++)
                {
                    if (i == 9)
                        users[i].Permissions = users[0].Permissions;
                    else
                        users[i].Permissions = users[i + 1].Permissions;
                }


                var userIdPermissionIdsMapping = new Dictionary<int, List<int>>();

                foreach (var user in users)
                {
                    if (user.UserTypeId != null)
                        userIdPermissionIdsMapping.Add(user.Id, user.Permissions.Select(u => u.Id).ToList());
                }

                db.SaveChanges();

                var updatedUsers = db.Users.Take(10).ToList();

                Assert.AreEqual(10, users.Count);

                foreach (var user in updatedUsers)
                {
                    List<int> userPermissionIdsList = null;

                    userIdPermissionIdsMapping.TryGetValue(user.Id, out userPermissionIdsList);

                    Assert.IsTrue(userPermissionIdsList != null);

                    Assert.IsTrue(user.Permissions.All(p => userPermissionIdsList.Contains(p.Id)));
                }
            }
        }


    }
}
