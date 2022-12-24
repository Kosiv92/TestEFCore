using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFCore
{
    public class AppDbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }

        public AppDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder ob) => ob.UseSqlite("Data Source=ApplicationDb");

        protected override void OnModelCreating(ModelBuilder mb)
        {
            var roles = DataFactory.Roles;
            var role1 = roles.FirstOrDefault(r => r.Id == Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"));
            var role2 = roles.FirstOrDefault(r => r.Id == Guid.Parse("b0ae7aac-5493-45cd-ad16-87426a5e7665"));

            mb.Entity<Role>()
                .OwnsMany(r => r.Employees)
                .HasData(
                new
                {
                    Id = role1.Id,
                    Name = role1.Name,
                    Employees = role1.Employees
                },
                new
                {
                    Id = role2.Id,
                    Name = role2.Name,
                    Employees = role2.Employees
                }
                );
        }

    }
}
