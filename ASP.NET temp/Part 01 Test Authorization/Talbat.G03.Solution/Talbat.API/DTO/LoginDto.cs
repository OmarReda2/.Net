using System.ComponentModel.DataAnnotations;

namespace Talbat.API.DTO
{
    //...p6.6 
    //p6.7
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
    //p6.8 return to AccountController...

}
