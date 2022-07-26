using AutoMapper;
using Demo.BLL.Helper;
using Demo.BLL.Interfaces;
using Demo.DAL.Entities;
using Demo.PL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

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
            var departments = _unitOfWork.DepartmentRepository.GetAll();
            var mappedDepartments = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);
            ViewData["Departments"] = mappedDepartments;

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
        public async Task<IActionResult> Create()
        {

            ViewBag.Departments = _unitOfWork.DepartmentRepository.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeViewModel employee)
        {
            #region Upload Image
            //string folderPadth = Directory.GetCurrentDirectory() + @"wwwroot\Files\Images";
            //string fileName = Guid.NewGuid() +  Path.GetFileName(employee.Image.FileName);
            //string filePath = Path.Combine(folderPadth, fileName);
            //using (var fileStream = new FileStream(filePath, FileMode.Create))
            //{
            //    employee.Image.CopyTo(fileStream);
            //}

            //employee.ImageName = fileName;
            #endregion
            #region Upload CV
            //folderPadth = Directory.GetCurrentDirectory() + @"wwwroot\Files\CVs";
            //fileName = Guid.NewGuid() + Path.GetFileName(employee.CV.FileName);
            //filePath = Path.Combine(folderPadth, fileName);
            //using (var fileStream = new FileStream(filePath, FileMode.Create))
            //{
            //    employee.CV.CopyTo(fileStream);
            //}

            //employee.CVName = fileName;
            #endregion
            employee.ImageName = DocumentSetting.Upload(employee.Image, "Images");
            employee.CVName = DocumentSetting.Upload(employee.CV, "CVs");



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
