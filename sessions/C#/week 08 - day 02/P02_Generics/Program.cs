using System;

namespace P02_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //int x = 10;
            //int y = 5;
            ////Point x = new Point(1, 5);
            ////Point y = new Point(5, 12);


            //Console.WriteLine($"X = {x}");
            //Console.WriteLine($"Y = {y}");


            //Helper<double>.Swap(ref x, ref y);
            ////Helper.Swap(ref x, ref y);



            //Console.WriteLine($"X = {x}");
            //Console.WriteLine($"Y = {y}");












            //Point[] points =
            //{
            //    new Point(1, 2),
            //    new Point(11, 4),
            //    new Point(50, 3)
            //};

            //Helper<Point>.BubbleSort(points);
            //foreach (var item in points)
            //{
            //    Console.WriteLine(item);
            //}
















            Employee emp01 = new Employee() { Id = 1, Name = "Ahmed" };
            Employee emp02 = new Employee() { Id = 2, Name = "Ali" };
            Employee emp03 = new Employee() { Id = 3, Name = "Omar" };


            //if (emp01 == emp02)
            //{
            //    Console.WriteLine("Equal");
            //}

            Employee[] emps = { emp01, emp02 };
            int position = Helper<Employee>.SearchArray(emps, new Employee() { Id = 10, Name = "Mai" });
            Console.WriteLine(position);


        }
    }
}