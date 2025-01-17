﻿using Demo.DAL.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.PL.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name Is Required")]
        [MaxLength(50, ErrorMessage ="Max Length is 50 chars")]
        [MinLength(10, ErrorMessage = "Min Length is 10 chars")]
        public string Name { get; set; }
        public string Address { get; set; }
        [DataType(DataType.Currency)]
        [Range(4000,8000 , ErrorMessage ="Salary must be between 4000 and 8000")]
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime HireDate { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public string ImageName { get; set; }
        public string CVName { get; set; }

        public IFormFile Image { get; set; }
        public IFormFile CV { get; set; }
    }
}
