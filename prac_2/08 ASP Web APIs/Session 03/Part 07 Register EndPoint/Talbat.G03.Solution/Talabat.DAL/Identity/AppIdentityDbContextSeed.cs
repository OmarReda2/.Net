using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities.Identity;

namespace Talabat.DAL.Identity
{
    //...p5.23
    //p5.24
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser()
                {
                    DisplayName = "Omar Reda",
                    UserName = "omarreda01",
                    Email = "omarredaelsayied@gmail.com",
                    PhoneNumber = "01027563659",
                    Address = new Address()
                    {
                        FirstName = "Omar",
                        LastName = "Reda",
                        Country = "Egypt",
                        City = "Giza",
                        Street = "Warraq Elnasr Housing "
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");

                //p.25 go to Program to call this method ...
            }
        }
    }
}
