using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(5, ErrorMessage ="Minimum Password Length is 5")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [MinLength(5, ErrorMessage = "Minimum Password Length is 5")]
        [Compare("Password", ErrorMessage = "Confirm Password does not match Password")]
        public string ConfirmPassword { get; set; }

        public bool IsAgree { get; set; }

    }
}
