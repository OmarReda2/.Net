using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Sealed_Class
{
    sealed class TypeOne : TypeTwo
    {
    }




    //internal class TypeTwo : TypeOne
    class TypeTwo

    {

    }




    abstract class TypeThree
    {
        public abstract void Method();
    }







    class TypeFor : TypeThree
    {
        public sealed override void Method()
        {
            Console.WriteLine("Hello");
        }
    }



    class TypeFive : TypeFor
    {
        //public override void Method()
        //{
        //    base.Method();
        //}
    }

}
