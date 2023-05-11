using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Departement
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Max Length is 50")]
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
