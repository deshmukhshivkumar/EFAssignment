using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModel
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserDbContext>
    {
        protected override void Seed(UserDbContext context)
        {
            
        }
    }
}
