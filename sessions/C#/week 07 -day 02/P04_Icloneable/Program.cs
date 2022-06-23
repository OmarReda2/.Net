using System;

namespace builtIn_interface
{
    class Project
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.Id = 1;
            //employee.Name = "Ahmed";
            //employee.Salary = 3000;


            #region ICloneable

            #region Deep Copy
            //Employee employee01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 3000 };
            //Employee employee02 = new Employee() { Id = 2, Name = "Ali", Salary = 5000 };

            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee02.GetHashCode());

            //employee01 = employee02; // deep 
            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee02.GetHashCode());
            #endregion







            #region Shallow Copy
            //Employee employee01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 3000 };
            //Employee employee02 = new Employee() { Id = 2, Name = "Ali", Salary = 5000 };

            //employee01 = new Employee(employee02);
            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee02.GetHashCode());
            //Console.WriteLine();

            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02);
            //Console.WriteLine();

            //employee01.Name = "Omar";
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02);
            //Console.WriteLine();






            //int[] arr01 = { 1, 2, 3 };
            //int[] arr02 = { 4, 5, 6 };
            //arr01 = (int[])arr02.Clone();

            //employee01 = (Employee)employee02.Clone();
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02);
            #endregion

            #endregion











            #region ICompararble
            Employee employee01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 3000 };
            Employee employee02 = new Employee() { Id = 2, Name = "Ali", Salary = 500 };
            Employee employee03 = new Employee() { Id = 3, Name = "Sara", Salary = 1000 };



            Employee[] emps = new Employee[] { employee01, employee02, employee03 };
            Array.Sort(emps);
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
            #endregion

        }
    }
}