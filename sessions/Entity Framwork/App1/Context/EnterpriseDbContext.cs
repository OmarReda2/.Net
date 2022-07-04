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

            public DbSet<Employee> Employees { get; set; }
    }

}
