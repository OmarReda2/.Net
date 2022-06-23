using System;

namespace _1_Polymorphism
{
    class Project
    {
        // Polymorohism => 1. Function Overloading => signature and return type
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public static double Sum(double x, int y, int z)
        {
            return x + y + z;
        }

        static void Main(string[] args)
        {
            double x = 10.5;
            int y = 20;
            int z = 30
            Console.WriteLine(Sum(x, y, z););
        }
    }
}