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
            
            mb.Entity<Role>().HasData(role1);
        }

    }
}
