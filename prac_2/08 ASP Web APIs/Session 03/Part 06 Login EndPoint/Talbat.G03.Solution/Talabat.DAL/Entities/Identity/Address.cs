using System.ComponentModel.DataAnnotations;

namespace Talabat.DAL.Entities.Identity
{
    // ...p5.3
    // p5.4
    public class Address
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        [Required]
        public string AppUserId { get; set; } // ForienKey
        public AppUser User { get; set; } // navigitional prop "1(User) to m(Address)"

        // p5.5 create Talabat.DAL.Identity
        // p5.5 create Talabat.DAL.Identity.AppIdentityDbContext
        // p5.5 go to Talabat.DAL.Identity.AppIdentityDbContext...

    }
}