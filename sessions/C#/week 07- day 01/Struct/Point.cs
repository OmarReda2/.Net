using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal struct Point
    {
        // Attribute [Member Variable]
        public int X;
        internal int Y;



        // Constructor
        public Point(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }

        public Point(int num)
        {
            X = Y = num;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}
