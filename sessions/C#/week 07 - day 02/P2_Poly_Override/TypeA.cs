using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Poly_Override
{
    class TypeA
    {
        public int A { get; set; }

        public TypeA(int _A)
        {
            A = _A;
        }

        public void StaticBindedShow()
        {
            Console.WriteLine("I am Base [Parent]");
        }

        public virtual void DynamicBindedShow()
        {
            Console.WriteLine($"TypeA {A}");
        }
    }


    class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int _B, int _A) : base(_A)
        {
            B = _B;
        }

        // Static Binded method (Early binding)
        public new void StaticBindedShow()
        {
            Console.WriteLine("I am Derived [Child]");
        }

        //public void Print()
        //{
        //    base.StaticBindedShow();
        //}

        // Dynamic Binded method (Late binding)
        // Non-private, virtual at first appearence

        public override void DynamicBindedShow()
        {
            //base.DynamicBindedShow();
            Console.WriteLine($"TypeB {A}, {B}");

        }



    }





    class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int _A, int _B, int _C):base(_A, _B)
        {
            C = _C;
        }

        public override void DynamicBindedShow()
        {
            //base.DynamicBindedShow();
            Console.WriteLine($"TypeC {A}, {B}, {C}");


        }
    }




    class TypeD : TypeC
    {
        public int D{ get; set; }

        public TypeD(int _A, int _B, int _C, int _D) : base(_A, _B, _C)
        {
            _D = D;
        }

        public new void DynamicBindedShow()
        {
            //base.DynamicBindedShow();
            Console.WriteLine($"TypeD {A}, {B}, {C}, {D}");


        }
    }

}
