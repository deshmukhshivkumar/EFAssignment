using System;
using System.Linq;
using DbModel;

namespace EFAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UserDbContext())
            {
                var list = db.Users.ToList();
                foreach (var item in list)
                {
                    Console.WriteLine(item.FirstName);
                    Console.ReadLine();
                }
            }
        }   
    }
}
