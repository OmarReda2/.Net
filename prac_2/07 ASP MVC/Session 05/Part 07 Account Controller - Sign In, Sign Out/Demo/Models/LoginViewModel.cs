﻿using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(5, ErrorMessage = "Minimum Password Length is 5")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
