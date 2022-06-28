using System;

namespace P04_Generic_Delegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            //List<int> list = Enumerable.Range(0, 100).ToList();
            //GenericCompareFunDelegate<int, int, bool> compare = CompareFunctions.CompareLessThan;
            //GenericSortingAlgorithm<int>.BubbleSort(list.ToArray(), compare);
            //foreach (var item in list)
            //    Console.WriteLine(item);



            List<string> names = new List<string>() { "Om", "Omar", "Oma", "Omar reda" };
            GenericCompareFunDelegate<string, string, bool> compare = CompareFunctions.CompareLength;
            GenericSortingAlgorithm<string>.BubbleSort(names.ToArray(), compare);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }

}