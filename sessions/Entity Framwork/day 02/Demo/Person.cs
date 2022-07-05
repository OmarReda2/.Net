using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public  class Person
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }


    public class Teacher : Person
    {
        public DateTime HireDate { get; set; }
    }



    public class Student : Person
    {
        public DateTime EnrollDate { get; set; }
    }
}
