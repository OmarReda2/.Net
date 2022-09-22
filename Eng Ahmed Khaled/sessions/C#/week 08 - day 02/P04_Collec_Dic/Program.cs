using System;
using System.Collections;

namespace P04_Collec_Dic
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Generic Collections [Dictionaries] - Dictionary
            Dictionary<string, long> PhoneBook = new Dictionary<string, long>();
            PhoneBook.Add("Ahmed", 1234567);
            PhoneBook.Add("Ali", 24681012);
            PhoneBook.Add("Omar", 35791113);

            foreach (KeyValuePair<string, long> item in PhoneBook)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }





            PhoneBook["Omar"] = 1000; // Update
            PhoneBook["Amr"] = 555; // Insert







            //PhoneBook.Add("Omar", 35791113)
            if (!PhoneBook.ContainsKey("Ahmed"))
                PhoneBook.Add("Ahmed", 777);
            else
                PhoneBook["Ahmed"] = 111;

            if (!PhoneBook.TryAdd("Ahmed", 0000))
                PhoneBook["Ahmed"] = 0000;






            //Console.WriteLine(PhoneBook["samir"]);
            Console.WriteLine(PhoneBook.TryGetValue("Samir", out long num));


            #endregion
        }
    }
}