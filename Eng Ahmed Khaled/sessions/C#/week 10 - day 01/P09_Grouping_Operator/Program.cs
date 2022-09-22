using P09_Grouping_Operator;
using static P09_Grouping_Operator.ListGenerators;
using System;

namespace P09_Grouping_Operator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             group p by p.Category;


            //var result = ProductList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category);


            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}










            //var result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //             into prodGroup
            //             where prodGroup.Count() > 10
            //             orderby prodGroup.Count() descending
            //             select new { Category = prodGroup.Key, Count = prodGroup.Count() };

            var result = ProductList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category)
                                    .Where(prodGroup => prodGroup.Count() > 10)
                                    .OrderByDescending(prodGroup => prodGroup.Count())
                                    .Select(prodGroup => new { Category = prodGroup.Key, Count = prodGroup.Count() });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



        }
    }
}