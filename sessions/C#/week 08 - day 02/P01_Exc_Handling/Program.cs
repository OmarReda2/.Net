using System;

namespace P01_Exc_Handling
{
    class Program
    {
        public static void DoSomething() {
            int x = 0; int y = 0; int z;
            try
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                z = x / y;
                Console.WriteLine(z);

                int[] Arr = new int[2];
                Arr[5] = 10;
            }


            //catch (Exception ex)
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                // Release Resources
                Console.WriteLine("Finally");
            }
        }


        public static void DoSomProtectiveCode()
        {
            int x = 0; int y = 0; int z;
            do
            {
                Console.WriteLine("Enter x");
            } while (!int.TryParse(Console.ReadLine(), out x));

            do
            {
                Console.WriteLine("Enter y");
            } while (!int.TryParse(Console.ReadLine(), out y) || y == 0);

            z = x / y;

        }
        static void Main(string[] args)
        {

            try
            {
                DoSomProtectiveCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //catch (CustomException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
