using System;
using System.Collections;

namespace P03_Collections
{
    class Program
    {
        public static int SumArrayList(ArrayList list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += (int)list[i];
            }
            return sum;
        }






        public static int SumList(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {

            #region Non-Generic Collections
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add("Ahmed");
            //arrayList.AddRange(new int[] { 1, 2, 3, 4 });

            //int result = SumArrayList(arrayList);
            //Console.WriteLine(result);
            #endregion








            #region Generic Collectons [Lists] - List
            List<int> list = new List<int>();
            Console.WriteLine($"Size = {list.Count} , Capacity = {list.Capacity}");

            list.Add(1);
            Console.WriteLine($"Size = {list.Count} , Capacity = {list.Capacity}");

            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine($"Size = {list.Count} , Capacity = {list.Capacity}");

            list.Add(5);
            Console.WriteLine($"Size = {list.Count} , Capacity = {list.Capacity}");

            //list.Add("Ahmed");
            list.AddRange(new int[] { 4, 5, 6, 7 });

            int result = SumList(list);
            Console.WriteLine(result);

            list[2] = 10;
            Console.WriteLine(list[2]);

            //list[100] = 100;

            Console.WriteLine($"Size = {list.Count} , Capacity = {list.Capacity}");
            list.TrimExcess();
            Console.WriteLine($"Size = {list.Count} , Capacity = {list.Capacity}");




            #endregion

        }
    }
}