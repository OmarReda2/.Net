using System.ComponentModel.DataAnnotations;

namespace Demo.PL.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email os Required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Email os Required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum Lengthb of password is 6 chars")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
