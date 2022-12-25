using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace TestEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ApllicationRunning...");


            //List<Role> roles = (List<Role>)DataFactory.Roles;

            //var role1 = roles.FirstOrDefault(r=>r.Id == Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"));

            //using (AppDbContext db = new AppDbContext())
            //{
            //    db.Roles.Add(role1);
            //    db.SaveChanges();
            //}
            
            PrintEntities();

            Console.ReadKey();
        }

        static void PrintEntities()
        {
            using (AppDbContext db = new AppDbContext())
            {
                var roles = db.Roles;

                foreach (var role in roles)
                {
                    Console.WriteLine($"ID:{role.Id} Name:{role.Name}\nEmployees:{role.Employees.Count}");
                }
            }
            Console.ReadKey();
        }
    }
}
