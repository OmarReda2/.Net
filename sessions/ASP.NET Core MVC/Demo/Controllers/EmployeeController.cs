using Demo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public <IActionResult> Create()
        {

        }
    }
}
