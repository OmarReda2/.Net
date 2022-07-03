using P11_Let_Into;
using static P11_Let_Into.ListGenerators;
using System;
using System.Text.RegularExpressions;

namespace P11_Let_Into
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>() { "ahmed", "ali", "sally", "osama" };

            //var result = from n in names
            //             select Regex.Replace(n, "[aeiouAEIOU]", String.Empty)
            //             into newVol
            //             where newVol.Length >= 3
            //             orderby newVol.Length descending
            //             select newVol;


            var result = from n in names
                         let newVol =  Regex.Replace(n, "[aeiouAEIOU]", String.Empty)
                         where newVol.Length >= 3
                         orderby newVol.Length descending
                         select newVol;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}