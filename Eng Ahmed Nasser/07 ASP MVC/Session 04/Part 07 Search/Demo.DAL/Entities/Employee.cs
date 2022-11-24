using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int? Age { get; set; }

        public string Address { get; set; }
        [DataType(DataType.Currency)]
        [Range(4000,8000, ErrorMessage="Salary Must Be Between 4000 and 8000")]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }
        
        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;



        public int DepartmentId { get; set; } // forign key by convention
        public virtual Department Department { get; set; } // relation (navigitional prop)
    }
}
