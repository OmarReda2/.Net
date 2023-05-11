using Demo.PL.Models;
using Demo.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Demo.BLL.Helper;

namespace Demo.PL.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<ApplicationUser> UserManager { get; }
        public SignInManager<ApplicationUser> SignInManager { get; }

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
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
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    IsAgree = model.IsAgree
                };
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                    return RedirectToAction(nameof(Login));
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
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
                if(user != null)
                {
                    await SignInManager.SignInAsync(user, true);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError(string.Empty, "Invalid Email");                    
            }
            return View(model);
        }

        public async new Task<IActionResult> SignOut()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var token = UserManager.GeneratePasswordResetTokenAsync(user);
                    var passwordresetLink = Url.Action("ResetPassword", "Account", new { Email = user.Email, Token = token }, Request.Scheme);

                    var Email = new Email()
                    {
                        Tilte = "Reset Password",
                        Body = passwordresetLink
                    };

                    EmailSetting.SendEmail(Email);
                    return RedirectToAction(nameof(CompleteForgetPassword));
                }
            }
            return View(model);
        }

        public IActionResult CompleteForgetPassword()
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }

        public IActionResult ResetPasswordDone()
        {
            return View();
        }

    }
}
