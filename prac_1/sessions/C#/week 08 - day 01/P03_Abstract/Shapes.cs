using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Abstract
{
    public abstract class Shape
    {
        public double Dim1 { get; set; }
        public double Dim2 { get; set; }

        public void Print()
        {
            Console.WriteLine("Hello");
        }






        // virtual + no implemenattion
        public abstract double CalcArea();

        public abstract double Perimeter { get; }

    }








    public abstract class RectangleBase : Shape
    {

        public override double CalcArea()
        {
            return Dim1 * Dim2;
        }
    }









    public class Rect : RectangleBase
    {
        public override double Perimeter
        {
            get
            {
                return 2 * (Dim1 + Dim2);
            }
        }
    }









    class Square : RectangleBase
    {
        public override double Perimeter
        {
            get
            {
                return 4 * Dim1;
            }
        }
    }





    public class Circle : Shape
    {
        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Dim1;
            }
        }


        public Circle(double Raduis)
        {
            Dim1 = Dim2 = Raduis;
        }

        public override double CalcArea()
        {
            return Math.PI * Dim1 * Dim1;
        }
    }
}
