using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Entities;
using Demo.PL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Demo.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var employees = _unitOfWork.EmployeeRepository.GetAll();
            var mappedEmplyees = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);
            return View(mappedEmplyees);
        }



        //public IActionResult Details(int? id)
        //{
        //    if (id == null)
        //        return NotFound();
        //    var employee = _unitOfWork.EmployeeRepository.Get(id);
        //    if (employee == null)
        //        return NotFound();

        //    return View(employee);
        //}
        public IActionResult Details(int? id)
        {

            if (id == null)
                return NotFound();



            var employee = _unitOfWork.EmployeeRepository.Get(id);
            var mappedEmployee = _mapper.Map<Employee, EmployeeViewModel>(employee);


            var empDepartment = _unitOfWork.EmployeeRepository.Get(id).DepartmentId;
            var department = _unitOfWork.DepartmentRepository.Get(empDepartment);
            var mappedEmpDept = _mapper.Map<Department, DepartmentViewModel>(department);
            ViewData["Departement"] = mappedEmpDept.Name;

            if (employee == null)
                return NotFound();

            return View(mappedEmployee);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = _unitOfWork.DepartmentRepository.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                var mappedEmployee = _mapper.Map<EmployeeViewModel, Employee>(employee);
                _unitOfWork.EmployeeRepository.Add(mappedEmployee);
                return RedirectToAction("Index");
            }
            ViewBag.Departments = _unitOfWork.DepartmentRepository.GetAll();
            return View(employee);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var employee = _unitOfWork.EmployeeRepository.Get(id);
            _unitOfWork.EmployeeRepository.Delete(employee);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var x = _unitOfWork.EmployeeRepository.Get(id).DepartmentId;
            var y = _unitOfWork.DepartmentRepository.Get(x).Name;
            ViewData["Department"] = y;
            ViewData["Departments"] = _unitOfWork.DepartmentRepository.GetAll();

            var employee = _unitOfWork.EmployeeRepository.Get(id);
            var mappedEmployee = _mapper.Map<Employee, EmployeeViewModel>(employee);

            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(int? id, EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                var mappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employee);
                _unitOfWork.EmployeeRepository.Update(mappedEmp);
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}
