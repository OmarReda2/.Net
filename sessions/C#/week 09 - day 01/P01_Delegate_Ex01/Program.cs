using System;

namespace P01_Delegate_Ex01
{
    // // Step 0: Delegate Declaration
    public delegate int StringFunctionDelegate(string s);






    public class Program
    {
        static void Main(string[] args)
        {
            //int result = SrtingFunctions.GetCountOfUpperCase("Omar Reda");
            //Console.WriteLine(result);

            // result = SrtingFunctions.GetCountOfLowerCase("Omar Reda");
            //Console.WriteLine(result);








            #region Ex 01
            // // Step 1: Declare reference from Delegate
            StringFunctionDelegate stringFunction;

            // // Step 2: Intialization Reference => Pointer to function
            stringFunction = new StringFunctionDelegate(SrtingFunctions.GetCountOfUpperCase);
            stringFunction = SrtingFunctions.GetCountOfUpperCase;

            int result;
            // // Step 3: Use the delegate 
            //result = stringFunction.Invoke("Omar Reda");
            //result = stringFunction("Omar Reda");
            //Console.WriteLine(result);

            stringFunction += SrtingFunctions.GetCountOfLowerCase;
            //result = stringFunction("Omar Reda");
            //Console.WriteLine(result);

            stringFunction -= SrtingFunctions.GetCountOfLowerCase;
            result = stringFunction("Omar Reda");
            Console.WriteLine(result);
            #endregion

        }
    }











    public class SrtingFunctions
    {
        public static int GetCountOfUpperCase(string str)
        {
            Console.WriteLine("GetCountOfUpperCase");
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    count++;

            }
            return count;
        }





        public static int GetCountOfLowerCase(string str)
        {
            Console.WriteLine("GetCountOfLowerCase");
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                    count++;

            }
            return count;
        }
    }
}