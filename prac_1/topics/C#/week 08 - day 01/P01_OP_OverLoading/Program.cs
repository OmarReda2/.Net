using System;

namespace P01_OP_OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {

            //Complex c1 = new Complex() { Real = 1, Imaginary = 2 };
            //Complex c2 = new Complex() { Real = 3, Imaginary = 4 };
            //Complex c3 = c1 + c2;
            //Console.WriteLine(c3);


            //Complex c1 = new Complex() ;
            //Complex c2 = new Complex() ;
            //Complex c3 = c1 + c2;
            //Console.WriteLine(c3);


            //Complex c1 = default;
            //Complex c2 = new Complex() ;
            //Complex c3 = c1 + c2;
            //Console.WriteLine(c3);


            //Complex c1 = new Complex() { Imaginary = 2, Real = 1};
            //Complex c2 = new Complex();
            //c1 = c1 + c1;
            //Console.WriteLine(c1);


            //Complex c1 = new Complex() { Imaginary = 2, Real = 1 };
            //Complex c2 = new Complex();
            //c1++;
            //Console.WriteLine(c1);


            //Complex c1 = new Complex() { Imaginary = 2, Real = 1 };
            //Complex c2 = new Complex() { Imaginary = 3, Real = 4 };

            //if (c1 > c2)
            //    Console.WriteLine("C1 is greater than C2");
            //else
            //    Console.WriteLine("C2 is greater than C1");


            Complex c1 = new Complex() { Imaginary = 2, Real = 1 };
            Complex c2 = new Complex() { Imaginary = 3, Real = 4 };
            int number = c1;
            string str = (string)c2;
            Console.WriteLine(number);
            Console.WriteLine(str);



        }
    }
}
