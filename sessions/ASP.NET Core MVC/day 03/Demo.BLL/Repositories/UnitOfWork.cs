using Demo.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IEmployeeRepository EmployeeRepository { get; set; }
        public IDepartementRepository DepartementRepository { get; set; }

        public UnitOfWork(IEmployeeRepository employeeRepository, IDepartementRepository departementRepository)
        {
            EmployeeRepository = employeeRepository;
            DepartementRepository = departementRepository;
        }

        public Interfaces.IDepartementRepository departementRepository { get; set; }
    }
}
