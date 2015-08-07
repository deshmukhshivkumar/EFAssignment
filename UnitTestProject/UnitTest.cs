
using System.Linq;
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
    }
}
