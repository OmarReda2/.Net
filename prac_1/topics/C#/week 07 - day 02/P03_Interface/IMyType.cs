using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Interface
{
    internal interface IMyType
    {
        public int salary { get; set; }

        void fucn01();
    }








    class MyType : IMyType
    {




        public int salary
        {
            set
            {
                this.salary = value;
            }
            get
            {
                return this.salary;
            }
        }

        public void fucn01()
        {
            Console.WriteLine("func01");
        }






    }
}
