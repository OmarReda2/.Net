using System;

namespace Struct
{
    public class Class1
    {
        static void Main(String[] args)
        {
            Point P01;
            P01 = new Point(1, 2);
            P01.X = 1; 
            P01.Y = 2;   

            Console.WriteLine(P01);
            Console.WriteLine(P01.ToString());
        }
    }
}







