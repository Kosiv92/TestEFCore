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
            mb.Entity<Role>().HasData(DataFactory.Roles);
        }

    }
}
