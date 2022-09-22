using System;
using P05_Trans_Select;
using static P05_Trans_Select.ListGenerators;

namespace P05_Trans_Select
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var result = ProductList.Select(p => p.ProductName);

            //var result = from p in ProductList
            //             select p.ProductName;






            //var result = CustomerList.SelectMany(p => p.Orders);

            //var result = from c in CustomerList
            //             from o in c.Orders
            //             select o;






            //var result = ProductList.Select(p => new { p.ProductID, p.ProductName, p.UnitPrice });

            //var result = from p in ProductList
            //             select new { p.ProductID, p.ProductName, p.UnitPrice };






            //var discountProducts = ProductList.Select(p => new
            //{
            //    ID = p.ProductID,
            //    Name = p.ProductName,
            //    ProductCategory = p.Category,
            //    Count = p.UnitsInStock,
            //    newPrice = p.UnitPrice * 0.2M
            //}).Where(p => p.Count > 10);

            //var discountProducts = from p in ProductList
            //                       select new
            //                       {
            //                           ID = p.ProductID,
            //                           Name = p.ProductName,
            //                           ProductCategory = p.Category,
            //                           Count = p.UnitsInStock,
            //                           newPrice = p.UnitPrice * 0.2M
            //                       } into newp
            //                       where newp.Count > 10
            //                       select newp;







            var result = ProductList.Select((p, index) => new { Index = index, ProductName = p.ProductName });










            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //foreach (var item in discountProducts)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}