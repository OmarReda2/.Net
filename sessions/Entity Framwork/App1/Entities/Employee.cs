using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Entities
{
    // // Data Convesion
    //public class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public double Salary { get; set; }
    //    public int? Age { get; set; }
    //} 





    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50, MinimumLength = 20)]
        [MaxLength(50)]
        public string Name { get; set; }


        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        [Range(18, 60)]
        public int? Age { get; set; }


        [DataType(DataType.EmailAddress)]
        public string EmailAddress{ get; set; }
    }
}
