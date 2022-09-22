using P08_Zip_Operator;
using static P08_Zip_Operator.ListGenerators;
using System;

namespace P08_Zip_Operator
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>() { "ahmed", "ali", "mai", "rawda" };
            //List<string> numbers = new List<string>() { "ahmed", "ali", "mai", "rawda" };
            var numbers = Enumerable.Range(0, 10);

            var result = names.Zip(numbers, (n, i) => new { Index = i, Name = n.ToUpper() });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}