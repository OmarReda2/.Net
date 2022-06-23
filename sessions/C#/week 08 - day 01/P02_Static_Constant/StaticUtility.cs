using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Static_Constant
{
    public class StaticUtility
    {




        // Static constructor
        static StaticUtility()
        {
            Pi = 3.14;
        }




        // Static Attribute
        static double Pi;





        // Static method (Class method
        public static double CalcCircleAria(double radius)
        {
            return Pi * radius * radius;
        }

    }
}
