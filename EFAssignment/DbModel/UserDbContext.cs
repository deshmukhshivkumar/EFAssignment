using System.Data.Entity;
namespace DbModel
{
    public class UserDbContext : DbContext
    {
        public UserDbContext()
            : base("name=UserDbContext")
        {
            
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<UserTypes> UserTypes { get; set; }
    }
}
