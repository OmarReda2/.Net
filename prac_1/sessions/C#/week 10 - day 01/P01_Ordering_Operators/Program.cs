using System;
using P01_Ordering_Operators;
using static P01_Ordering_Operators.ListGenerators;
namespace P01_Ordering_Operators
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //var result = ProductList.OrderBy(p => p.UnitsInStock)
            //                        .Select(p => new {p.ProductName, p.UnitsInStock });

            //var result = from p in ProductList
            //             orderby p.UnitsInStock
            //             select new { p.ProductName, p.UnitsInStock };





            // // Descending
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock)
            //                        .Select(p => new { p.ProductName, p.UnitsInStock });

            //var result = from p in ProductList
            //             orderby p.UnitsInStock descending
            //             select new { p.ProductName, p.UnitsInStock };






            // // Ordering By Multiple Columns
            //var result = ProductList.OrderBy(p => p.UnitsInStock)
            //                        .ThenBy(p => p.UnitPrice)
            //                        .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });

            //var result = from p in ProductList
            //             orderby p.UnitsInStock, p.UnitPrice 
            //             select new { p.ProductName, p.UnitsInStock, p.UnitPrice };






            //var result = ProductList.OrderByDescending(p => p.UnitsInStock)
            //                        .ThenByDescending(p => p.UnitPrice)
            //                        .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });

            //var result = from p in ProductList
            //             orderby p.UnitsInStock descending, p.UnitPrice descending
            //             select new { p.ProductName, p.UnitsInStock, p.UnitPrice };





            // // Reverse Operators
            var result = ProductList.Select(p => p.ProductName).Reverse();


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

    }
}