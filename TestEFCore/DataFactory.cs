using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFCore
{
    public static class DataFactory
    {
        public static ICollection<Role> Roles => new List<Role>()
        {
            new Role()
            {
                Id = Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"),
                Name = "Admin",
                Employees= new List<Employee>()
                {
                    Employees.FirstOrDefault(e => e.Id == Guid.Parse("451533d5-d8d5-4a11-9c7b-eb9f14e1a32f"))
                }
            },
            new Role()
            {
                Id = Guid.Parse("b0ae7aac-5493-45cd-ad16-87426a5e7665"),
                Name = "PartnerManager",
                Employees= new List<Employee>()
                {
                    Employees.FirstOrDefault(e => e.Id == Guid.Parse("f766e2bf-340a-46ea-bff3-f1700b435895"))
                }
            }
        };

        public static ICollection<Employee> Employees => new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.Parse("451533d5-d8d5-4a11-9c7b-eb9f14e1a32f"),
                Name = "Иван",
                Role = Roles.FirstOrDefault(r => r.Id == Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"))
            },
            new Employee()
            {
                Id = Guid.Parse("f766e2bf-340a-46ea-bff3-f1700b435895"),
                Name = "Петр",
                Role = Roles.FirstOrDefault(r => r.Id == Guid.Parse("b0ae7aac-5493-45cd-ad16-87426a5e7665"))
            }
        };


    }
}
