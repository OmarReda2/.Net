using P05_Generator_Operators;
using static P05_Generator_Operators.ListGenerators;
using System;

namespace P05_Generator_Operators
{
    class Program
    {
        public static void Main(string[] args)
        {


            //var result = Enumerable.Range(0, 100);
            //var result = Enumerable.Repeat(10, 5);
            var result = Enumerable.Empty<Product>(); /* or */ var result2 = new List<Product>();

            foreach (var item in result)
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}