using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Generics
{
    internal class Helper<T> where T : IComparable
        //internal class Helper

    {


        #region Non-Generic
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }

        public static void Swap(ref string x, ref string y)
        {
            string temp = x;
            x = y;
            y = temp;
        }

        public static void Swap(ref Point x, ref Point y)
        {
            Point temp = x;
            x = y;
            y = temp;
        }

        #endregion








        

        
        public static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        //public static void Swap<T>(ref T x, ref T y)
        //{
        //    T temp = x;
        //    x = y;
        //    y = temp;
        //}
       





        public static void BubbleSort(T[] Arr)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                for (int j = 0; j < Arr?.Length - i - 1; j++)
                {
                    //if (Arr[j] > Arr[j + 1] )
                    if (Arr[j].CompareTo(Arr[j + 1]) == 1)
                        Swap(ref Arr[j], ref Arr[j + 1]);
                }
            }

        }





        public static int SearchArray(T[] Arr, T emp)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                if (Arr[i].Equals(emp))
                    return i;                
            }
            return -1;
        }


         



        //public static  int Sum(T x, T y)
        //{
        //    return x + y;
        //}





    }








    struct Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Employee Left, Employee Right)
        {
            return Right.Equals(Left);
        }

        public static bool operator !=(Employee Left, Employee Right)
        {
            return (!Right.Equals(Left));
        }

    }
}
