using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal struct PhoneBook
    {
        long[] Numbers;
        string[] Names;
        int size;





        public int Size
        {
            get { return size; }
        }





        #region Indexer
        // indexer => special property\
        public long this[string name]
        {
            get
            {
                for (int i = 0; i < Names?.Length; i++)
                {
                    if (name == Names[i])
                        return Numbers[i];

                }


                return -1;
            }


            set
            {
                for (int i = 0; i < Names?.Length; i++)
                {
                    if (name == Names[i])
                        Numbers[i] = value;
                }
            }
        }



        //public string this[int index]
        //{
        //    get
        //    {

        //        for (int i = 0; i < Names?.Length; i++)
        //        {
        //            if (index == Numbers[i])
        //                return Names[i];

        //        }


        //        return null;
        //    }
        //}



        public string this[int index]
        {
            get
            {
                return $"{index} :: {Names[index]} :: {Numbers[index]}";
            }
        }

        #endregion














        public PhoneBook(int _size)
        {
            size = _size;
            Names = new string[size];
            Numbers = new long[size];
        }











        public long GetNumber(string name)
        {
            for (int i = 0; i < Names?.Length; i++)
            {
                if(name == Names[i])
                {
                    return Numbers[i];
                }
            }


            return -1;
        }





        public void AddNumber(string name, long number, int position)
        {
            if(position >= 0 && position < size)
            {
                Names[position] = name;
                Numbers[position] = number;
            }
        }




    }
}
