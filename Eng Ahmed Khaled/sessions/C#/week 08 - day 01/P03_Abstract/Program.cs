using System;

namespace P03_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Rect r1 = new Rect() { Dim1 = 2, Dim2 = 5 };
            Console.WriteLine(r1.CalcArea());

            Circle circle = new Circle(10);
            Console.WriteLine(circle.Perimeter);
            Console.WriteLine(circle.CalcArea());
        }
    }
}