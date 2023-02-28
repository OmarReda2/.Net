using AutoMapper;
using Demo.BLL.Interface;
using Demo.DAL.Entities;
using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMapper _mapper;
        public IUnitOfWork UnitOfWork { get; }

        public EmployeeController(
            IUnitOfWork unitOfWork, // - Make all Repo in one object - Define Its DI in startup 
            IMapper mapper) // configure DI in Startup
        {
            UnitOfWork = unitOfWork;
            _mapper = mapper;
        }




        public async Task<IActionResult> Index(string SearchValue)
        {
            if (string.IsNullOrEmpty(SearchValue)) // to return all the employee when  the searValue is empty
            {
                var employees =
                    _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(await UnitOfWork.EmployeeRepository.GetAll());
                return View(employees);
            }

            else
            //  - to return specific the employees when  the searValue is NOT empty
            //  - it will have another function so we will add it to IEmployeeRepo. and EmployeeRepo.
            {
                var employees =
                    _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(await UnitOfWork.EmployeeRepository.SearchEmployee(SearchValue));
                return View(employees);
            }

        }





        public async Task<IActionResult> Details(int? id, string ViewName = "Details")
        {
            if (id == null)
                return NotFound();
            var employee = await UnitOfWork.EmployeeRepository.Get(id);
            if (employee == null)
                return NotFound();

            var employeeVM = _mapper.Map<Employee, EmployeeViewModel>(await UnitOfWork.EmployeeRepository.Get(id));
            return View(ViewName, employeeVM);
        }





        public async Task<IActionResult> Create()
        {
            ViewBag.Departments = await UnitOfWork.DepartmentRepository.GetAll(); // only accessable for this action/view
            return View();
        }







        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModel employeeVM)
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
                await UnitOfWork.EmployeeRepository.Add(employee);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Departments = await UnitOfWork.DepartmentRepository.GetAll(); // reditect make ViewBag null
            return View(employeeVM);
        }









        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Departments = await UnitOfWork.DepartmentRepository.GetAll(); // only accessable for this action/view
            return await Details(id, "Edit");
        }






        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] int? id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var employee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                    await UnitOfWork.EmployeeRepository.Update(employee);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(employeeVM);
                }
            }
            ViewBag.Departments = UnitOfWork.DepartmentRepository.GetAll();
            return View(employeeVM);
        }







        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");
        }








        [HttpPost]
        public async Task<IActionResult> Delete([FromRoute] int? id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            try
            {
                var employee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                await UnitOfWork.EmployeeRepository.Delete(employee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(employeeVM);
            }
        }
    }
}
