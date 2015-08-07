using System.Data.Entity;

namespace DbModel
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserDbContext>
    {

        public override void InitializeDatabase(UserDbContext context)
        {
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
                , string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

            base.InitializeDatabase(context);
        }

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
