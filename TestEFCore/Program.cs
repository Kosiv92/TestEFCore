using System;

namespace TestEFCore
{
    internal class Program
    {
        static void Main(string[] args)
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
