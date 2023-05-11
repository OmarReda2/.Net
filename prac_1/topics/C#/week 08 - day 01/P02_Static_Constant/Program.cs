using System;

namespace P02_Static_Constant
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Utility u1 = new Utility(2, 5);
            //Console.WriteLine(u1.CM2Inch(20));

            Console.WriteLine(Utility.CM2Inch(20));
            Console.WriteLine(Utility.CalcCircleAria(5));
        }
    }
}