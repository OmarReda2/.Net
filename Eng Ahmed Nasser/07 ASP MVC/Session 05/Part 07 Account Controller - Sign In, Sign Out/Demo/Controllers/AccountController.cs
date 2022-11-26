using Demo.DAL.Entities;
using Demo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<ApplicationUser> UserManager { get; }
        public SignInManager<ApplicationUser> SignInManager { get; }
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        //- NOTE: we have added the DI for userManager and signInManager in startup "AddAuthentication"
        //  as AddAuthentication have the DI for them 
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        // - vmodel is the data filled by user in view in inputs which was binded with RegisterViewModel prop
        // - model:as the data come from view as RegisterViewModel
        {
            if (ModelState.IsValid) //client side validation (from the notation we added in RegisterViewModel)
            {
                //mapping RegisterViewModel ot ApplicationUser/IdentityUser
                var user = new ApplicationUser()
                {
                    UserName = model.Email.Split('@')[0],
                    Email = model.Email,
                    IsAgree = model.IsAgree
                };

                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                    return RedirectToAction(nameof(Login));
                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
                // - ModelState(server side validation) be shown in <div asp-validation-summary="All"></div> in RegisterView
                //   we use it like if the user is already exist so it will return errors
            }
            return View(model);//when we say "return View(model)" we will return the same page with same inputs user write
        }



        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var password = await UserManager.CheckPasswordAsync(user, model.Password);
                    if (password)
                    {
                        var result = await SignInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                        if (result.Succeeded)
                            return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View(model);
        }


        public async new Task<IActionResult> SignOut()
        // we add the "new" keyword as we the "controller" that "Account" inherit have this same functions so the "new"
        // let us to use ours function and hide the other one
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

    }
}
