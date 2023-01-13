using System.ComponentModel.DataAnnotations;

namespace Talbat.API.DTO
{
    //...p7.2 
    //p7.3
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName{ get; set; }
        [Required]
        public string Email{ get; set; }
        [Required]
        public string PhoneNumber{ get; set; }
        [Required]
        public string Password{ get; set; }
        public string City{ get; set; }
        public string Country{ get; set; }
        public string Street{ get; set; }
    }
    
}
