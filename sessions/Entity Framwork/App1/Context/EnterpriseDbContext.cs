using App1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Context
{
    internal class EnterpriseDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("data source = .; intial catalog =  EnterpriseDb; integrated security = true");
            optionsBuilder.UseSqlServer("server = .; database =  EnterpriseDb; integrated security = true");
        }







        // // Fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departement>().HasKey(D => D.DeptId);
            modelBuilder.Entity<Departement>().ToTable("Departements");
            modelBuilder.Entity<Departement>()
                .Property(D => D.DeptName)
                .IsRequired(true)
                .IsUnicode(true);

            modelBuilder.Entity<Departement>()
                .Property(D => D.YearOfCreation)
                .HasDefaultValue(DateTime.Now);


            // modelBuilder.Entity<Departement>(EB =>
            //{
            //    EB.HasKey(D => D.DeptId);
            //    EB.Property(D => D.YearOfCreation).HasDefaultValue(DateTime.Now);
            //});

            base.OnModelCreating(modelBuilder);







            modelBuilder.ApplyConfiguration(new DepartementConfigration());

        }






        public DbSet<Employee> Employees { get; set; }
    }

}
