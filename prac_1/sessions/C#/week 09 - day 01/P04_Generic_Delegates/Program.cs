using System;

namespace P04_Generic_Delegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region P04
            //List<int> list = Enumerable.Range(0, 100).ToList();
            //GenericCompareFunDelegate<int, int, bool> compare = CompareFunctions.CompareLessThan;
            //GenericSortingAlgorithm<int>.BubbleSort(list.ToArray(), compare);
            //foreach (var item in list)
            //    Console.WriteLine(item);



            //List<string> names = new List<string>() { "Om", "Omar", "Oma", "Omar reda" };
            //GenericCompareFunDelegate<string, string, bool> compare = CompareFunctions.CompareLength;
            //GenericSortingAlgorithm<string>.BubbleSort(names.ToArray(), compare);
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion





            #region P05 Built-in-deligate
            // //Predicate
            Predicate<string> compare = CompareFunctions.CompareLength2;

            // //Func
            Func<string, string, bool> compare2 = CompareFunctions.CompareLength;



            // //Action
            Action<string> action = OtherFunctions.Print;
            action("omar");
            action.Invoke("omar");




            // //Anonymous method
            Action<string> action2 = delegate (string str) { Console.WriteLine(str); };

            Action<string> action3 = (str) => { Console.WriteLine(str); };
            Action<string> action4 = (str) =>  Console.WriteLine(str); ;

            Func<int, string> func = (x) => { return x.ToString(); };
            Func<int, string> func2 = (x) => x.ToString();

            #endregion



        }
    }




    class OtherFunctions
    {
        public static void Print(string str)
        {
            Console.WriteLine("Hello");
        }
    }


}