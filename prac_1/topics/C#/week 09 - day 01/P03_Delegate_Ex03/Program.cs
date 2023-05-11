using System;

namespace P03_Delegate_Ex03
{
    public delegate bool ConditionFunDelegate(int a);






    class Program
    {

        //public static List<int> GetOddNumbers(List<int> list)
        //{
        //    List<int> oddNumbers = new List<int>();
        //    foreach (var item in list)
        //    {
        //        if (item % 2 == 1)
        //            oddNumbers.Add(item);
        //    }

        //    return oddNumbers;
        //}

        public static List<int> GetElementsBasedOnPassedFunction(List<int> list, ConditionFunDelegate condition)
        {
            List<int> elements = new List<int>();
            foreach (var item in list)
            {
                if (condition(item) == true)
                    elements.Add(item);
            }

            return elements;
        }








        static void Main(string[] args)
        {
            //List<int> list = Enumerable.Range(0, 100).ToList();
            //List<int> oddNumbers = GetOddNumbers(list);

            //foreach (var item in oddNumbers)
            //{
            //    Console.WriteLine(item);
            //}






            List<int> list = Enumerable.Range(0, 100).ToList();
            //List<int> oddNumbers = GetOddNumbers(list, ConditionFunctions.CheckOdd);
            //List<int> oddNumbers = GetOddNumbers(list, ConditionFunctions.CheckEven);
            List<int> elements = GetElementsBasedOnPassedFunction(list, ConditionFunctions.CheckBySeven);

            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }

        }
    }










    public class ConditionFunctions
    {
        public static bool CheckOdd(int x) { return x % 2 == 1; }
        public static bool CheckEven(int x) { return x % 2 == 0; }
        public static bool CheckBySeven(int x) { return x % 7 == 0; }
        
    }
}