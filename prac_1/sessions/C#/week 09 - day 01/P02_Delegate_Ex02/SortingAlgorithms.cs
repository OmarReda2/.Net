using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Delegate_Ex02
{
    public delegate bool CompareFunDelegate(int A, int B);







    public class SortingAlgritms
    {
        //public static void BubbleSort(int[] Arr)
        //{
        //    for (int i = 0; i < Arr?.Length; i++)
        //        for (int j = 0; j < Arr?.Length - i - 1; j++)
        //            if (Arr[j] > Arr[j + 1])
        //                SWAP(ref Arr[j], ref Arr[j + 1]);
        //}


        public static void BubbleSort(int[] Arr, CompareFunDelegate compare)
        {
            for (int i = 0; i < Arr?.Length; i++)
                for (int j = 0; j < Arr?.Length - i - 1; j++)
                    //if (compare(Arr[j], Arr[j + 1]) == true)
                    if (compare?.Invoke(Arr[j], Arr[j + 1]) == true)
                        SWAP(ref Arr[j], ref Arr[j + 1]);
        }





        public static void SWAP(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
    }





    class CompareFunctions
    {
        public static bool CompareGreaterThan(int x, int y) { return x > y; }

        public static bool CompareLessThan(int x, int y) { return x < y; }

    }
}
