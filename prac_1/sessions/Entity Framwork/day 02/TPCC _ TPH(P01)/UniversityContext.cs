using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class UniversityContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("server = . ; database = UniversityDb; integrated security = true");



        // // TPH
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasBaseType<Person>();
            modelBuilder.Entity<Teacher>().HasBaseType<Person>();
            base.OnModelCreating(modelBuilder);

        }




        // // TPCC
        //public DbSet<Teacher> Teachers { get; set; }
        //public DbSet<Student> Students { get; set; }




        // // TPH
        public DbSet<Person> Persons { get; set; }

    }


}
