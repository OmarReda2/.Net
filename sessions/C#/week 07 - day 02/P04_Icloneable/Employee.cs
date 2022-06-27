using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builtIn_interface
{
    internal class Employee: ICloneable, IComparable
    {
        #region Properties
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Salary { get; set; }
        #endregion








        #region Constructor
        public Employee()
        {

        }

        public Employee(Employee emp)
        {
            Id = emp.Id;
            Name = emp.Name;
            Salary = emp.Salary;
        }

        public Employee(int _id, string _name, decimal _salary)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
        }
        #endregion





        #region Methods
        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }


        public object Clone()
        {
            return new Employee(this);
        }


        public int CompareTo(object? obj)
        {
            Employee Right = (Employee)obj;
            if(this.Salary<Right.Salary)
                return -1;
            else if(this.Salary > Right.Salary)
                return 1;
            else
                return 0;
        }


        #endregion


    }
}
