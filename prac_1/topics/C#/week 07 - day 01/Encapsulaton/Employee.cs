using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulaton
{
    internal struct Employee
    {


        #region Attributes
        private int id;
        private string name; 
        private decimal salary;
        #endregion





        #region Property
        // 1. full property
        // snipt => propfull
        public decimal Salary
        {
            get { return salary; }
            set
            {
                salary = value < 2000 ? value : 1200; // control value
            }

        }



        // 2. Automatic prop
        // snippt => prop
        public int Age { get; set; }
        public decimal deductions
        {
            get { return salary * 0.5M; }
        }
        #endregion






        #region Constructor
        public Employee(int _Id, string _Name, decimal _Salary, int _Age)
        {
            id = _Id;
            name = _Name;
            salary = _Salary;
            Age = _Age;


        }
        #endregion





        #region Setter and Getter
        public string GetName()
        {
            return name;
        }


        public void SetName(string val)
        {
            name = val.Length <= 30 ? val : val.Substring(0, 20);
        }
        #endregion





        #region Overwride
        public override string ToString()
        {
            return $"{id} :: {name} :: {salary} :: {Age}";
        }
        #endregion


    }

}
