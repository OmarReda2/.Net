using Encapsulaton;
using System;

namespace Struct
{
    public class Class1
    {
        static void Main(String[] args)
        {
            Employee emp01 = new Employee(1, "Ahmed", 5000, 25);

            emp01.Salary = 2000; // Set
            Console.WriteLine(emp01.GetName()); // Get  
            Console.WriteLine(emp01.ToString());
        }
    }
}







