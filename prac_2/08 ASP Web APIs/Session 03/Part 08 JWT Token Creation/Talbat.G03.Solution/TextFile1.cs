#region p1
// go to productSpecParams
#endregion

#region p2
// create Talabat.DAL.Entities.BasketItem
// go to Talabat.DAL.Entities.BasketItem ...
#endregion

#region p3
// p3.1 create Talabat.BLL.Interfaces.IBasketRepository
// p3.1 go to Talabat.BLL.Interfaces.IBasketRepository...
#endregion

#region p4
// create Controllers.BaskerController
// p4.1 go to Controllers.BasketController ...
#endregion

#region p5
// p5.1 install Microsoft.AspNetCore.Identity.EntityFrameworkCore package in DAL
// p5.1 create DAL.Entities.Identity.AppUser
// p5.1 go to DAL.Entities.Identity.AppUser
#endregion

#region p6
/* 
 p6.1 make new controller "AccountController" for register and login end point
 p6.1 go to "AccountController" ...
 
 
 */
#endregion

#region p7
/* 
 p7.1 go to accountController to make the register endPoint ...
 */
#endregion

#region p8
/* --- jwt ---
 1- create interface ITokenService and create "CreateToken" function signature
 2- create "service" folder same to repository folder and create "TokenService" class that imp. the "ITokenService"
 3- download jwtBearer package in Talabat.API 
 4- add in the "IdentityServiceExtension" class (we use it in the startup):
    - add the "jwt" in services.AddAuthentication()(we used to add the cookies)

 services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {

                });


  5-  start imp the "CreateToken" func in TokenService class:
    - add registerd claim/payload and key in "appsetting" to use it in "CreateToken" function 
    - inject IConfiguration in TokenService to use appsetting in "CreateToken" function
    - see the details "TokenService" class

  6-
    - inject the ITokenService and Assign field in AccountController and add the di in  "ApplicationServiceExtension" in startup
    - add "createToken" function in Account controller:
          return Ok(new UserDto()
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
===>>           Token = await _tokenService.CreateToken(user, _userManager) // add token
            });

    7- add [authorize] on the controller"productController" that you want to be authorized
    8- validate on token in "IdentityServiceExtension" in startup
        - inject the "IConfiguration" and assign field in the startup,
        - then pass the the field as a parameter in "IdentityServiceExtension"
        - see the details of validation in "IdentityServiceExtension"

    9-DONT FORGET TO ADD MIDDLE WARES OF AUTHENTICATION & AUTHORIZATION
    10- Identify jwt scheme in [Authorize] in productController ==> "[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] "

    11-NOTE:
        instead of "[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]" in productController, but we will still use "[Authorize]"

             options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme; 
                    /// we use this instead of [Authorize] in productController as it the same if we add the authorize in the all project (Global)
                })

 */
#endregion