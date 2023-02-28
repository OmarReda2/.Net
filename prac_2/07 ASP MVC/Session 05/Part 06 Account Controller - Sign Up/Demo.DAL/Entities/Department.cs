using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code Is Required")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        [StringLength(100, MinimumLength =5,ErrorMessage = "Name Length Must Be Between 5 and 100")]
        public string Name { get; set; }

        public DateTime DateOfCreation { get; set; }

        public virtual ICollection<Employee> Employee { get; set; } = new HashSet<Employee>(); // relation 1 to m
    }
}
