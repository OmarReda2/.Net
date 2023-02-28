using P10_Partitioning_Operators;
using static P10_Partitioning_Operators.ListGenerators;
using System;

namespace P10_Partitioning_Operators
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var result = ProductList.Where(p => p.UnitsInStock == 0).Take(3);

            //var result = ProductList.Where(p => p.UnitsInStock == 0).TakeLast(3);

            //var result = ProductList.Where(p => p.UnitsInStock == 0).Skip(2);

            //var result = ProductList.Where(p => p.UnitsInStock == 0).SkipLast(2);





            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((n, i) => n > i);

            var result = numbers.SkipWhile(n => n % 3 != 0);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}