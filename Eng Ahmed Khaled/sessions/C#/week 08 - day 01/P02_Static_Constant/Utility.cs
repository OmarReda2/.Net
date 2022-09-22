using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Static_Constant
{
    public class Utility
    {
        public int X{ get; set; }
        public int Y{ get; set; }

        public Utility(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }






        //// Static constructor
        //static Utility()
        //{
        //    Pi = 3.14;
        //}

        //// Static Attribute
        //static double Pi;








        // Constant
        const double Pi = 3.14;



        // Static method (Class method)
        public static double CM2Inch(double cm)
        {
            return cm / 2.54;
        }

        public static double CalcCircleAria(double radius)
        {
            return Pi * radius * radius;
        }

    }
}
