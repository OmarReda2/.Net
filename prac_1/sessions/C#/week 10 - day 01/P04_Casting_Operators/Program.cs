using P04_Casting_Operators;
using static P04_Casting_Operators.ListGenerators;
using System;

namespace P04_Casting_Operators
{
    class Program
    {
        public static void Main(String[] args)
        {
            // // Casting Operators - immediate Execution
            List<Product> products = ProductList.Where(p => p.UnitsInStock == 0).ToList();

            Product[] prodArr = ProductList.Where(p => p.UnitsInStock == 0).ToArray();

            //Dictionary<long, Product> prodDic = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);  
            Dictionary<long, string> prodDic = ProductList.Where(p => p.UnitsInStock == 0)
                                               .ToDictionary(p => p.ProductID, p => p.ProductName);

            HashSet<Product> prodSet = ProductList.Where(p => p.UnitsInStock == 0).ToHashSet();
        }
    }
}