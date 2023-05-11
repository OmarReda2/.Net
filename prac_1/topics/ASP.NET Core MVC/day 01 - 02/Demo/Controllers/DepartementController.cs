using Demo.Data;
using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class DepartementController : Controller
    {
        private readonly ApplicationDBContext _context;

        public DepartementController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Deprtements.ToList());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var departement = await _context.Deprtements.FindAsync(id);
            if (id == null)
                return NotFound();
            return View(departement);
        }






        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var departement = _context.Deprtements.Find(id);
            if (id == null)
                return NotFound();
            return View(departement);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Departement dept)
        {
            if (id != dept.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Deprtements.Update(dept);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {

                    throw;
                }
                return RedirectToAction("Index");
            }
            return View(dept);
        }

        public IActionResult Delete(int? id)
        {
            var dept = _context.Deprtements.Find(id);
            _context.Deprtements.Remove(dept);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }





        [HttpGet]
        public IActionResult Create()
        {            
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Departement dept)
        {
            if (ModelState.IsValid)
            {
                await _context.Deprtements.AddAsync(dept);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(dept);
        }

    }
}
