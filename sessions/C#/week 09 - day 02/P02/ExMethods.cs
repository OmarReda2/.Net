using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    public static class ExMethods
    {
        public static int Mirror(this IComparable num)
        {
            var numArr = num.ToString().ToCharArray();
            Array.Reverse(numArr);
            return int.Parse(numArr);
        }
    }
}
