using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Generics
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }






        public int CompareTo(object? obj)
        {
            //Point Right = (Point)obj; 

            //if(obj is Point Right)
            //{
            //    if(Right == null)
            //        return 1;
            //    if(this.X == Right.X)
            //        return this.Y.CompareTo(Right.Y);
            //    else
            //        return this.X.CompareTo(Right.X);
            //}


            Point Right = obj as Point;
            if (Right == null)
                return 1;
            if (this.X == Right.X)
                return this.Y.CompareTo(Right.Y);
            else
                return this.X.CompareTo(Right.X);
        }

        public int CompareTo(Point? Right)
        {
            if (this.X == Right.X)
                return this.Y.CompareTo(Right.Y);
            else
                return this.X.CompareTo(Right.X);
        }
    }
}
