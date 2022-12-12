using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.DAL.Entities.Identity
{
    //...p5.1
    // p5.2
    public class AppUser:IdentityUser
    {
        public string  DisplayName { get; set; }

        // p5.3 generate class Address in new file
        // p5.3 go to Address class...
        public Address Address { get; set; }
    }
}
