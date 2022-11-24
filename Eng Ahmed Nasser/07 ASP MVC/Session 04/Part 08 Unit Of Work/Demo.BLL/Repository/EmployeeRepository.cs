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
    public class EmployeeRepository:GenericRepository<Employee>, IEmployeeRepository
    {
        public MVCAppContext Context { get; }

        public EmployeeRepository(MVCAppContext context):base(context)
        {
            Context = context;
        }


        public IEnumerable<Employee> GetEmployeesByDepartmentName(string departmentName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> SearchEmployee(string value)
        => Context.Employees.Where(E => E.Name.Contains(value));
    }
}
