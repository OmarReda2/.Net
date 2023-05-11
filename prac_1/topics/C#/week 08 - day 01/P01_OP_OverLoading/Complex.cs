using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_OP_OverLoading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        //public Complex(int _real, int _imaginary)
        //{
        //    Real = _real;   
        //    Imaginary = _imaginary;
        //}









        #region opertaor overloading
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imaginary = (Left?.Imaginary ?? 0) + (Right?.Imaginary ?? 0),

            };
        }


        public static Complex operator ++(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) + 1,
                Imaginary = (c?.Imaginary ?? 0) + 1
            };
        }

        public static bool operator >(Complex Left, Complex Right)
        {
            if (Left?.Real != Right?.Real)
                return Left?.Real > Right?.Real;
            else
                return Left?.Imaginary > Right?.Imaginary;
        }


        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left?.Real != Right?.Real)
                return Left?.Real < Right?.Real;
            else
                return Left?.Imaginary < Right?.Imaginary;
        }


        public static implicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }


        public static explicit operator string(Complex C)
        {
            return C?.ToString() ?? "Not Found";
        }
        #endregion












        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
