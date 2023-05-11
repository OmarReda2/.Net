using System;
using P02_Element_Operators;
using static P02_Element_Operators.ListGenerators;
namespace P02_Element_Operators
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list2 = new List<int>();

            //var result = ProductList.First(); 
            //var result = list2.First();

            //var result = ProductList.last(); 
            //var result = list2.last();

            //var result = ProductList.First(p => p.UnitsInStock == 0);
            //var result = ProductList.Last(p => p.UnitsInStock == 0);

            //var result = ProductList.FirstOrDefault();
            //var result = list2.FirstOrDefault();
            //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 1000);

            //var result = ProductList.LastOrDefault(p => p.ProductName == "ali");
            //Console.WriteLine(result?.ProductName ?? "NA");







            //var result = ProductList.ElementAt(3);
            //var result = ProductList.ElementAtOrDefault(3000);
            //Console.WriteLine(result?.ProductName ?? "NA");







            //List<int> list = new List<int>() { 1 };
            //var result = ProductList.Single();
            //var result = list.Single();

            //var result = ProductList.Single(p => p.UnitsInStock == 0);
            //var result = ProductList.Single(p => p.UnitsInStock == 125);

            //var result = ProductList.SingleOrDefault(p => p.UnitsInStock == 8888);
            //Console.WriteLine(result?.ProductName ?? "NA");






            // // Hybrid Syntax
            var result = (from p in ProductList
                          where p.UnitPrice == 30
                          select new { p.ProductName, p.Category }).FirstOrDefault();


            Console.WriteLine(result);






        }
    }
}