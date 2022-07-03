using P06_Set_Operators;
using static P06_Set_Operators.ListGenerators;
using System;

namespace P06_Set_Operators
{
    class Program
    {
        public static void Main(string[] args)
        {
            var seq1 = Enumerable.Range(0, 100);
            var seq2 = Enumerable.Range(50, 150);

            //var result = seq1.Union(seq2);

            //var result = seq1.Concat(seq2);

            //var result = (seq1.Concat(seq2)).Distinct();

            //var result = seq1.Intersect(seq2);

            var result = seq1.Except(seq2);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        
        }
    }
}