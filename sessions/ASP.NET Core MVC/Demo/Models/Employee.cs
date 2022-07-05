using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [ForeignKey("Departement")]
        [Display(Name = "Departement")]
        public int FK_DepartementId { get; set; }
        public virtual Departement Departement { get; set; }

    }
}
