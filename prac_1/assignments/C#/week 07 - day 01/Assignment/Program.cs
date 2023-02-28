using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of the employees");
            int x = int.Parse(Console.ReadLine());


            Employee[] arr = Employee.GetEmpArr(x);
            Employee.FillData(arr);
            Employee.printArr(arr);
            Console.WriteLine("After Sorting");
            Employee.sortArrOfEmp(arr);
            Employee.printArr(arr);
            
        }
    }
}