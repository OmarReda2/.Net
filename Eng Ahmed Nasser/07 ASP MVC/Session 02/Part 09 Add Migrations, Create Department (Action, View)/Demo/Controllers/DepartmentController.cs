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
            return View(departmentRepository.GetAll()); 
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
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }
    }
}
