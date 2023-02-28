using System.ComponentModel.DataAnnotations;

namespace Demo.PL.Models
{
    public class ResetPasswordViewModel
    {
        public string Password { get; set; }
        [Required(ErrorMessage = "Email os Required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum Lengthb of password is 6 chars")]
        [Compare("Password", ErrorMessage = "Confirm password does not match password")]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
