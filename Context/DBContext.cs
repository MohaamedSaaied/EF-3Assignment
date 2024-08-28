using EF_3InhertanceExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_3InhertanceExample.Context
{
    internal class DBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //modelBuilder.Entity<Employee>().ToTable("Employees");
            //modelBuilder.Entity<FullTimeEmp>().ToTable("FullTimeEmps");
            //modelBuilder.Entity<PartTimeEmp>().ToTable("PartTimeEmps");
           

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EF3;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmp> FullTimeEmps { get; set; }
        public DbSet<PartTimeEmp> PartTimeEmps { get; set; }


    }


}
