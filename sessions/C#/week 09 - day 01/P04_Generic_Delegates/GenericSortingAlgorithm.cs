using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Generic_Delegates
{
    public delegate TResult GenericCompareFunDelegate<T1, T2, TResult>(T1 x, T2 y);
    public class GenericSortingAlgorithm<T>
    {










        public static void BubbleSort(T[] Arr, GenericCompareFunDelegate<T, T, bool> compare)
        {
            for (int i = 0; i < Arr?.Length; i++)
                for (int j = 0; j < Arr?.Length - i - 1; j++)
                    //if (compare(Arr[j], Arr[j + 1]) == true)
                    if (compare?.Invoke(Arr[j], Arr[j + 1]) == true )
                        SWAP(ref Arr[j], ref Arr[j + 1]);
        }





        public static void SWAP(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
    }





    class CompareFunctions
    {
        public static bool CompareLength(string str1, string str2) { return str1?.Length > str2?.Length; }
        public static bool CompareGreaterThan(int x, int y) { return x > y; }

        public static bool CompareLessThan(int x, int y) { return x < y; }

    }
}

