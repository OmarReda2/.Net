using Demo.Data;
using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDBContext _context;

        public EmployeeController(ApplicationDBContext context) // Dependecy Injection for context
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _context.Employees.Include(E => E.Departement).ToArrayAsync();
            return View(result);
        }





        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Departement"] = _context.Deprtements.ToList();
            //or
            //ViewBag.Departements = _context.Deprtements.ToList();
            //or
            //TempData
            return View();
        }

      
        [HttpPost]
        public async Task<IActionResult> Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                await _context.Employees.AddAsync(emp);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(emp);
        }





        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var employee = await _context.Employees.FindAsync(id);
            if (id == null)
                return NotFound();
            return View(employee);
        }




        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ViewData["Departement"] = _context.Deprtements.ToList();
            if (id == null)
                return NotFound();

            var employee = _context.Employees.Find(id);
            if (id == null)
                return NotFound();
            return  View(employee);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Employee emp)
        {
            if (id != emp.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Employees.Update(emp);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {

                    throw;
                }
                return RedirectToAction("Index");
            }
            return View(emp);
        }


        public IActionResult Delete(int? id)
        {
            var emp = _context.Employees.Find(id);
            _context.Employees.Remove(emp);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
