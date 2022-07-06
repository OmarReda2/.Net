using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        

        public DbSet<Departement> Deprtements { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
