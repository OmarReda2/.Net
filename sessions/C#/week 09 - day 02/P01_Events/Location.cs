using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Events
{
    public struct Location
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public override string ToString() => $"{X}, {Y}, {Z}";

        public static bool operator ==(Location Right, Location Left)
            => Right.X == Left.X && Right.Y == Left.Y && Right.Z == Left.Z;

        public static bool operator !=(Location Right, Location Left)
            => Right.X != Left.X && Right.Y != Left.Y && Right.Z != Left.Z;
        
    }


}
