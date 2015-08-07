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
                //db.Users.Add(new Users()
                //{
                //    Id = 1,
                //    FirstName = "Shiv",
                //    LastName = "Deshmukh"
                //});
                //db.SaveChanges();
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
