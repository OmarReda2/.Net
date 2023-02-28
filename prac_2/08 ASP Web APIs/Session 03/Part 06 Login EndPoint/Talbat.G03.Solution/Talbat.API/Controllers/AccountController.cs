using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Talabat.DAL.Entities.Identity;
using Talbat.API.DTO;
using Talbat.API.Errors;

namespace Talbat.API.Controllers
{
    //...p6.1
    //p6.2
    public class AccountController : BaseController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //p6.3 create Talbat.API.DTO.UserDto
        //p6.3 go to Talbat.API.DTO.UserDto...
        //...p6.5

        //p6.6 create Talbat.API.DTO.LoginDto
        //p6.6 go to Talbat.API.DTO.LoginDto...
        //...p6.8
        //p6.9
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null) return Unauthorized(new ApiResponse(401));
            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if(!result.Succeeded) return Unauthorized(new ApiResponse(401));
            return Ok(new UserDto()
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
                Token = "This will be Token"
            });
        }
    }
}
