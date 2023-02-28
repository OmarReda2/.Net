using AutoMapper;
using Demo.BLL.Interface;
using Demo.DAL.Entities;
using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Demo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMapper _mapper;

        public IEmployeeRepository EmployeeRepository { get; }
        public IDepartmentRepository DepartmentRepository { get; }

        public EmployeeController(
            IEmployeeRepository employeeRepository,
            IDepartmentRepository departmentRepository,
            IMapper mapper) // configure DI in Startup
        {
            EmployeeRepository = employeeRepository;
            DepartmentRepository = departmentRepository;
            _mapper = mapper;
        }




        public IActionResult Index(string SearchValue)
        {
            if (string.IsNullOrEmpty(SearchValue)) // to return all the employee when  the searValue is empty
            {
                var employees =
                    _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(EmployeeRepository.GetAll());
                return View(employees);
            }

            else
            //  - to return specific the employees when  the searValue is NOT empty
            //  - it will have another function so we will add it to IEmployeeRepo. and EmployeeRepo.
            {
                var employees =
                    _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(EmployeeRepository.SearchEmployee(SearchValue));
                return View(employees);
            }

        }





        public IActionResult Details(int? id, string ViewName = "Details")
        {
            if (id == null)
                return NotFound();
            var employee = EmployeeRepository.Get(id);
            if (employee == null)
                return NotFound();

            var employeeVM = _mapper.Map<Employee, EmployeeViewModel>(EmployeeRepository.Get(id));
            return View(ViewName, employeeVM);
        }





        public IActionResult Create()
        {
            ViewBag.Departments = DepartmentRepository.GetAll(); // only accessable for this action/view
            return View();
        }







        [HttpPost]
        public IActionResult Create(EmployeeViewModel employeeVM)
        {
            //Manaull Mapping
            ///var mappedEmp = new Employee()
            ///{
            ///    Id = employeeVM.Id,
            ///    Name = employeeVM.Name,
            ///    Address = employeeVM.Address,
            ///    Age = employeeVM.Age,
            ///    DepartmentId = employeeVM.DepartmentId,
            ///    Email = employeeVM.Email,
            ///    IsActive = employeeVM.IsActive,
            ///    HireDate = employeeVM.HireDate,
            ///    PhoneNumber = employeeVM.PhoneNumber,
            ///    Salary = employeeVM.Salary,
            ///    //CreationDate => not in the employeeVM, default: Creation.Now
            ///
            ///};

            //AutoMapping
            var employee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);

            if (ModelState.IsValid) // server side validation
            {
                EmployeeRepository.Add(employee);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Departments = DepartmentRepository.GetAll(); // reditect make ViewBag null
            return View(employeeVM);
        }









        public IActionResult Edit(int? id)
        {
            ViewBag.Departments = DepartmentRepository.GetAll(); // only accessable for this action/view
            return Details(id, "Edit");
        }






        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute] int? id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var employee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                    EmployeeRepository.Update(employee);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(employeeVM);
                }
            }
            ViewBag.Departments = DepartmentRepository.GetAll();
            return View(employeeVM);
        }







        public IActionResult Delete(int? id)
        {
            return Details(id, "Delete");
        }








        [HttpPost]
        public IActionResult Delete([FromRoute] int? id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            try
            {
                var employee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                EmployeeRepository.Delete(employee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(employeeVM);
            }
        }
    }
}
