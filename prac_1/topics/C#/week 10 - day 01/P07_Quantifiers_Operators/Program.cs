using P07_Quantifiers_Operators;
using static P07_Quantifiers_Operators.ListGenerators;
using System;

namespace P07_Quantifiers_Operators
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Console.WriteLine(ProductList.Any());
            //Console.WriteLine(ProductList.Any(p => p.UnitsInStock == 0));
            //Console.WriteLine(ProductList.All(p => p.ProductID == 10));

            var seq1 = Enumerable.Range(1, 10);
            var seq2 = Enumerable.Range(10, 20);
            Console.WriteLine(seq1.SequenceEqual(seq2));
        }
    }
}