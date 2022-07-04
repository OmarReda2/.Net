using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Entities
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public int Name { get; set; }
        public int Age { get; set; }
    }
}
