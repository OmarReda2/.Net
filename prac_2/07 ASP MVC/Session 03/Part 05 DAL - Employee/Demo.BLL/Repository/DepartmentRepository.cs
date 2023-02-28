using Demo.BLL.Interface;
using Demo.DAL.Contexts;
using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly MVCAppContext context;

        public DepartmentRepository(MVCAppContext context) // configure DI in Startup
        {
            this.context = context;
        }

        public int Add(Department department)
        {
            context.Departments.Add(department);
            return context.SaveChanges();
        }

        public int Delete(Department department)
        {
            context.Departments.Remove(department);
            return context.SaveChanges();
        }

        public Department Get(int? id)
        => context.Departments.FirstOrDefault(D => D.Id == id);

        public IEnumerable<Department> GetAll()
        => context.Departments.ToList();

        public int Update(Department department)
        {
            context.Departments.Update(department);
            return context.SaveChanges();
        }
    }
}
