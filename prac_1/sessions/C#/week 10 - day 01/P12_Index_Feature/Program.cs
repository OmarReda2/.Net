using P12_Index_Feature;
using static P12_Index_Feature.ListGenerators;
using System;

namespace P12_Index_Feature
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] numbers = Enumerable.Range(0, 20).ToArray();
            Console.WriteLine(numbers[^1]);




            int[] newNumbers = numbers[0..9];
            foreach (var item in newNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}