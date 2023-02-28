using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Child:Parent
    {

        #region Properties
        public int Z { get; set; }
        #endregion







        #region Constructors
        //public Child(int _X, int _Y, int _Z)
        //{
        //    X = _X; 
        //    Y = _Y;
        //    Z = _Z;
        //}


        //public Child(int _X, int _Y, int _Z)
        //public Child(int _X, int _Y, int _Z) : base()
        public Child(int _X, int _Y, int _Z) : base(_X, _Y)
        {
            Z = _Z;
            Console.WriteLine("Constructor of child class");
        }
        #endregion








        #region Methods
        //public int Product()
        //{
        //    return X * Y * Z;
        //}

        public new int Product()
        {
            return base.Product() * Z;
        }
        #endregion









        public override string ToString()
        {
            return $"{X} :: {Y} :: {Z}";
        }
    }
}
