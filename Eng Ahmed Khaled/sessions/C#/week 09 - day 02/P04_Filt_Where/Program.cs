using System;
using P04_Filt_Where;
using static P04_Filt_Where.ListGenerators;

namespace P04_Filt_Where
{
    class Program
    {
        public static void Main(string[] args)
        {
            //result = ProductList.Where(p => p.UnitsInStock == 0);

            //var result = from p in ProductList
            //             where p.UnitsInStock == 0
            //             select p;




            //var result = ProductList.Where(p => p.UnitsInStock == 0 && p.Category == "Meat/Poultry");

            //var result = from p in ProductList
            //             where p.UnitsInStock == 0 && p.Category == "Meat/Poultry
            //             select p;




            var result = ProductList.Where((p, index) => p.UnitsInStock == 0 && index > 10);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}