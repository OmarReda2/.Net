using System;

namespace P2_Poly_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Polymorphism => 2. Function Override (Binding)
            //TypeA typeA = new TypeA(2);
            //typeA.StaticBindedShow();

            //TypeB typeB = new TypeB(1, 2);
            //typeB.StaticBindedShow();
            //typeB.DynamicBindedShow();
            //typeB.Print();

            //TypeA typeA = new TypeB(1, 2);
            //typeA.A = 1;
            //typeA.StaticBindedShow();
            //typeA.DynamicBindedShow();

            //TypeA typeA = new TypeC(4, 5, 6);
            //typeA.DynamicBindedShow();

            //TypeB typeb = new TypeC(1, 2, 3);
            //typeb.DynamicBindedShow();

            //TypeA typeA = new TypeD(1, 2, 3, 4);
            //typeA.DynamicBindedShow();







            // // practice with my self
            TypeB typeB = new TypeB(1, 2);
            typeB.DynamicBindedShow();

            TypeA typeA = new TypeB(1, 2);
            typeA.DynamicBindedShow();
        }
    }

}
