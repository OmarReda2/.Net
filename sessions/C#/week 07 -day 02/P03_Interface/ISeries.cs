using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Interface
{
    internal interface ISeries
    {
        public int Current { get; }

        void GetNext();

        void Reset();
    }


    public struct SeriesByTwo : ISeries
    {
        int current;
        public int Current
        {
            get { return current; }
        }

        public void GetNext()
        {
            current += 2;
        }

        public void Reset()
        {
            current = 0;
        }
    }




    public struct SeriesByThree : ISeries
    {
        int current;
        public int Current
        {
            get { return current; }
        }

        public void GetNext()
        {
            current += 3;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
