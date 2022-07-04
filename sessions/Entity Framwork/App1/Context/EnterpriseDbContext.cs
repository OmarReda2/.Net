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






        // // Mapping with Fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // // Commented as it was made in Configration Class
            //modelBuilder.Entity<Departement>().HasKey(D => D.DeptId);
            //modelBuilder.Entity<Departement>().ToTable("Departements");
            //modelBuilder.Entity<Departement>()
            //    .Property(D => D.DeptName)
            //    .IsRequired(true)
            //    .IsUnicode(true);

            //modelBuilder.Entity<Departement>()
            //    .Property(D => D.YearOfCreation)
            //    .HasDefaultValue(DateTime.Now);

            // // modelBuilder.Entity<Departement>(EB =>
            // //{
            // //    EB.HasKey(D => D.DeptId);
            // //    EB.Property(D => D.YearOfCreation).HasDefaultValue(DateTime.Now);
            // //});






            // // One To Many Mapping With Fluent Api
            //modelBuilder.Entity<Departement>()
            //    .HasMany(D => D.Employees)
            //    .WithOne(E => E.Departement);

            //modelBuilder.Entity<Employee>()
            //    .HasOne(E => E.Departement)
            //    .WithMany(D => D.Employees);






            // // Many To Many Mapping With Fluent Api
            modelBuilder.Entity<StudentCourse>().HasKey(SC => new { SC.StudentId, SC.CourseId });

            



            // // Mapping with Configration Class
            modelBuilder.ApplyConfiguration(new DepartementConfigration());
 




            base.OnModelCreating(modelBuilder);
        }





        // // Mapping With Convention
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }

}
