using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Parent
    {

        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion






        #region Constructors
        public Parent(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
            Console.WriteLine("Constructor of Parent class");

        }

        public Parent()
        {
        }
        #endregion






        #region Methods
        public int Product()
        {
            return X * Y;
        }
        #endregion






        public override string ToString()
        {
            return $"{X} :: {Y}";
        }

    }
}
