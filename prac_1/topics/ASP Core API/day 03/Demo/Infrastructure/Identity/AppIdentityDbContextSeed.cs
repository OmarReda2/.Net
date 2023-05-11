using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "John1",
                    Email = "john1@gmail.com",
                    UserName = "john1@gmail.com",
                    Address = new Address
                    {
                        FirstName = "John1",
                        LastName = "Doe",
                        Street = "10 Street",
                        City = "New York",
                        State = "NY",
                        ZipCode = "90210"
                    }
                };

                await userManager.CreateAsync(user, "Password123!");
            }
        }
    }
}
