using System;

namespace Inheritance
{
    public class Project
    {
        static void Main(String[] args)
        {
           Parent P01 = new Parent(1, 2);
            Console.WriteLine(P01);
            Console.WriteLine(P01.Product());



            Child C01 = new Child(1, 2, 3);
            Console.WriteLine(C01);
            Console.WriteLine(C01.Product());


        }
    }
}







