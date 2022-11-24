using Demo.BLL.Interface;
using Demo.BLL.Repository;
using Demo.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository) // configure DI in Startup
        {
            this.departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            ViewData["Message"] = "Hello View Data";
            ViewBag.Message = "Hello View Bag";
            return View(departmentRepository.GetAll()); 
        }
        public IActionResult Details(int? id, string ViewName = "Details")
        {
            if (id == null)
                return NotFound();
            var Department = departmentRepository.Get(id);
            if (Department == null)
                return NotFound();
            return View(ViewName, Department);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                departmentRepository.Add(department);
                TempData["Message"] = "Departement is Created Succesfully";


                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        public IActionResult Edit(int? id)
        {
            return Details(id, "Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute]int? id, Department department)
        {
            if(id != department.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    departmentRepository.Update(department);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(department);
                }
            }
            return View(department);
        }

        public IActionResult Delete(int? id)
        {
            return Details(id, "Delete");
        }

        [HttpPost]
        public IActionResult Delete([FromRoute]int? id, Department department)
        {
            if (id != department.Id)
                return BadRequest();
            try
            {
                departmentRepository.Delete(department);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(department);
            }
        }
    }
}
