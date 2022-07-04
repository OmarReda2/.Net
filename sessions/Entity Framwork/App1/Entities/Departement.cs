using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Entities
{
    public class Departement
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public DateTime YearOfCreation { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

        public Departement()
        {
            Employees = new HashSet<Employee>(); // to intialize THe Icollection or (it well be null in DB xxxxxxx)
        }
    }
}
