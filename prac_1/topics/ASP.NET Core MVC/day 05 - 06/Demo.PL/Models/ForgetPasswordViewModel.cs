﻿using System.ComponentModel.DataAnnotations;

namespace Demo.PL.Models
{
    public class ForgetPasswordViewModel
    {
        [Required(ErrorMessage = "Email os Required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}
