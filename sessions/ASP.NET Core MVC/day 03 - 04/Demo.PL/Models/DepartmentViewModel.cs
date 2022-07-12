using System.ComponentModel.DataAnnotations;

namespace Demo.PL.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public int Code { get; set; }
        [Required(ErrorMessage ="Name Is Required")]
        [MaxLength(50, ErrorMessage = "Max Length is 50 chars")]
        [MinLength(10, ErrorMessage = "Min Length is 10 chars")]
        public string Name { get; set; }
    }
}
