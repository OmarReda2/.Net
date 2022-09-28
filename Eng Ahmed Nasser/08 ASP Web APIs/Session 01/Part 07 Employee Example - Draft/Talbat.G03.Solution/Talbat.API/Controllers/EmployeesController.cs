using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Talabat.BLL.Interfaces;
using Talabat.BLL.Specifications;
using Talabat.BLL.Specifications.Employees;
using Talabat.DAL.Entities;

namespace Talbat.API.Controllers
{
    public class EmployeesController : BaseController
    {
        private readonly IGenericRepository<Employee> _employeeRepo;

        public EmployeesController(IGenericRepository<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Employee>>> GetEmployees()
        {
            var spec = new EmployeeWithDepartementSpecification();
            var employees = await _employeeRepo.GetAllWithSpecAsync(spec);
            return Ok(employees);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<IReadOnlyList<Employee>>> GetEmployees(int id)
        {
            var spec = new EmployeeWithDepartementSpecification(id);
            var employees = await _employeeRepo.GetByIdWithSpecAsync(spec);
            return Ok(employees);
        }
    }
}
