using System.Data.Entity;

namespace DbModel
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserDbContext>
    {
        protected override void Seed(UserDbContext context)
        {
            var users = Helper.GetUsers(50);

            foreach (var user in users)
            {
                context.Users.Add(user);
            }
            base.Seed(context);
        }
    }
}
