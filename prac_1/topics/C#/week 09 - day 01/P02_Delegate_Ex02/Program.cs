using System;

namespace P02_Delegate_Ex02
{







    public class Program
    {
        static void Main(string[] args)
        {


            int[] Numbers = { 2, 7, -4, 6, -3, 0, 10 };

            //SotingAlgritm.BubbleSort(Numbers);
            //foreach (var item in Numbers)
            //    Console.WriteLine(item);

            //CompareFunDelegate compare= CompareFunctions.CompareGreaterThan;

            //SortingAlgritms.BubbleSort(Numbers, CompareFunctions.CompareGreaterThan);
            SortingAlgritms.BubbleSort(Numbers, CompareFunctions.CompareLessThan);
            foreach (var item in Numbers)
                Console.WriteLine(item);





        }
    }
}