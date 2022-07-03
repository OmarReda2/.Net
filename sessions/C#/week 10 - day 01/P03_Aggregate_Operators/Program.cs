using P03_Aggregate_Operators;
using static P03_Aggregate_Operators.ListGenerators;
using System;

namespace P03_Aggregate_Operators
{
    class Program
    {
        public static void Main(string[] args)
        {
            // // Aggregate Operators - Immediate Execution
            //var result = ProductList.Count();
            //var result = ProductList.Count(p => p.UnitsInStock == 0);



            //var result = ProductList.Max();
            //var result = ProductList.Max(p => p.UnitPrice);




            //var result = ProductList.Min(p => p.ProductName.Length);

            //var result = (from p in ProductList
            //              where p.ProductName.Length == ProductList.Min(p => p.ProductName.Length)
            //              select p).FirstOrDefault();





            //var result = ProductList.Sum(p => p.UnitPrice);

            //var result = ProductList.Average(p => p.UnitPrice);




            string[] names = { "Omar", "Reda", "Elayed" };
            var result = names.Aggregate((str1, str2) => $"{str1} {str2}");
            Console.WriteLine(result);


        }
    }
}