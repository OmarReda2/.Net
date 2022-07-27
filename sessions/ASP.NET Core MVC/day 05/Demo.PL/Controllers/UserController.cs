using Demo.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    public class UserController : Controller
    {
        public UserManager<ApplicationUser> _userManager { get; }
        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var users = _userManager.Users;
            return View(users);
        }

        public async Task<IActionResult> Details(string id, string ViewName = "Details")
        {
            if (id == null)
                return NotFound();
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
                return NotFound();
            return View(ViewName, user);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            return await Details(id, "Edit"); 
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, ApplicationUser model)
        {
            if (id != model.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.FindByIdAsync(id);
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.NormalizedUserName = model.UserName.ToUpper();
                    user.NormalizedEmail = model.Email.ToUpper();
                    user.SecurityStamp = model.SecurityStamp;
                    user.IsAgree = model.IsAgree;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View(model);
                }
            }
            return View(model);
        }
    }
}
