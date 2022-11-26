using Demo.DAL.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }
        [Range(22, 60, ErrorMessage = "Age Must Be Between 22 and 60")]
        public int? Age { get; set; }

        public string Address { get; set; }
        [DataType(DataType.Currency)]
        [Range(4000, 8000, ErrorMessage = "Salary Must Be Between 4000 and 8000")]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }
        [EmailAddress]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //[Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }

        public int DepartmentId { get; set; } // forign key by convention
        public virtual Department Department { get; set; } // relation (navigitional prop)



        public string ImageName { get; set; }

        //- we will use ImageName + Image prop to get the image it self 
        //- we will add an input in createView or CreateEditEmployeePartialView to have the image itself and bind with the Image prop
        public IFormFile Image { get; set; }
        //- IFormFile is a datatype which store any file with any extension
        //- we will use the a func to upload the file "Controller/Helper/DocumentSetting.cs"
       
    }
}
