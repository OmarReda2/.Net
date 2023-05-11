using System;

namespace P03_Interface
{
    class Project
    {

        //public static void ProcessSeries(SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current},");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine(series.Current);
        //}


        //public static void ProcessSeries(SeriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current},");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine(series.Current);
        //}


        public static void ProcessSeries(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current},");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine(series.Current);
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            //MyType myType = new MyType();
            //myType.fucn01();

            SeriesByTwo series = new SeriesByTwo();
            ProcessSeries(series);

            SeriesByThree byThree = new SeriesByThree();
            ProcessSeries(byThree);
        }
    }
}
