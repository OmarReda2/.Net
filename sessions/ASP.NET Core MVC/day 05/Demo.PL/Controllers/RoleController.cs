﻿using Demo.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    public class RoleController : Controller
    {
        public RoleManager<IdentityRole> _roleManager { get; }
        public UserManager<ApplicationUser> _userManager { get; }

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        public async Task<IActionResult> Details(string id, string ViewName = "Details")
        {
            if (id == null)
                return NotFound();
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
                return NotFound();
            return View(ViewName, role);
        }


        public IActionResult Create(string id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _roleManager.CreateAsync(role);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return View(role);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            return await Details(id, "Edit");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, IdentityRole model)
        {
            if (id != model.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    var role = await _roleManager.FindByIdAsync(id);
                    role.Name = model.Name;

                    var result = await _roleManager.UpdateAsync(role);
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

        public async Task<IActionResult> Delete(string id)
        {
            return await Details(id, "Delete");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id, IdentityRole model)
        {
            if (id != model.Id)
                return NotFound();

            try
            {
                IdentityResult result = await _roleManager.DeleteAsync(model);
                if (result.Succeeded)
                    return RedirectToAction("Index");

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }

                return View(model);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

