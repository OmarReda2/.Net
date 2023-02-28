using Demo.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Contexts
{
    //public class MVCAppContext:DbContext
    public class MVCAppContext: IdentityDbContext // we will use IdentityDbContext instead of DbContext
    {
        public MVCAppContext(DbContextOptions options) : base(options)
        {

        }

        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("Server=.; DataBase=MVCAppDb; Trusted_Connction = true;MultipleActiveResultSets=true;"); 

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
