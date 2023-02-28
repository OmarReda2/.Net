using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Specifications.Employees
{
    public class EmployeeWithDepartementSpecification : BaseSpecification<Employee>
    {
        public EmployeeWithDepartementSpecification()
        {
            AddIncludes(E => E.Departement);
        }

        public EmployeeWithDepartementSpecification(int id) : base(E => E.id == id)
        {
            AddIncludes(E => E.Departement);
        }
    }
}
