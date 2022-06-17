





using System.Text;

class program
{
    #region 2- Named and default input parameter
    //public static void printLines()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        Console.WriteLine('#');
    //    }
    //}

    //public static void printLines(int number = 5, string pattern = "$")
    //{
    //    for (int i = 0; i < number; i++)
    //    {
    //        Console.WriteLine(pattern);
    //    }
    //}
    #endregion



    //public static void swap(int x, int y)
    //{
    //    int temp = x;
    //    x = y;
    //    y = temp;
    //    Console.WriteLine($"Num1 = {x} , Num2 = {y}");

    //}


    //public static void swap(ref int x,ref int y)
    //{
    //    int temp = x;
    //    x = y;
    //    y = temp;
    //    Console.WriteLine($"Num1 = {x} , Num2 = {y}");

    //}








    //public static int sumArr(int[] Arr)
    //{
    //    int sum = 0;
    //    //Arr[0] = 0;
    //    Arr = new int[] { 4, 5, 6 };

    //    for (int i = 0; i < Arr.Length; i++)
    //    {
    //        sum = sum + Arr[i];
    //    }
    //    return sum;
    //}


    //public static int sumArr(ref int[] MyArr)
    //{
    //    int sum = 0;
    //    //Arr[0] = 0;
    //    MyArr = new int[] { 4, 5, 6 };

    //    for (int i = 0; i < MyArr.Length; i++)
    //    {
    //        sum = sum + MyArr[i];
    //    }
    //    return sum;
    //}






    public static int sumArr2(ref int[] MyArr)
    {
        int sum = 0;

        for (int i = 0; i < MyArr.Length; i++)
        {
            sum = sum + MyArr[i];
        }
        return sum;
    }



    public static void sumMul(int x, int y,out int sum,out int mul)
    {
        sum = x + y;
        mul = x * y;
    }


    public static void Main()
    {
        #region 1- stringBuilder
        //string msg = "Hello";
        //Console.WriteLine(msg.GetHashCode()) ;

        //msg = msg + "World";
        //Console.WriteLine(msg.GetHashCode());



        //StringBuilder msg = new StringBuilder();

        //msg.Append("Hello");
        //Console.WriteLine(msg.GetHashCode());

        //msg.Append("Omar");
        //Console.WriteLine(msg.GetHashCode());
        #endregion

        //printLines(3,"%");
        //printLines(3, "\\ omar \\");
        //printLines(3, @"\ omar \");
        //printLines(10);
        //printLines(pattern: "*");

        #region 3- Value type
        // // Pass by value 
        //int num1 = 5, num2 = 6;
        //Console.WriteLine($"Num1 = {num1} , Num2 = {num2}");

        //swap(num1, num2);
        //Console.WriteLine($"Num1 = {num1} , Num2 = {num2}");

        // // Pass by reference
        //int num1 = 5, num2 = 6;
        //Console.WriteLine($"Num1 = {num1} , Num2 = {num2}");

        //swap(ref num1,ref num2);
        //Console.WriteLine($"Num1 = {num1} , Num2 = {num2}");
        #endregion



        #region 4- Reference type
        // // Pass by value
        //int[] Arr = { 1, 2, 3 };
        //Console.WriteLine(sumArr(Arr));
        //Console.WriteLine(Arr[0]);

        // // Pass by reference
        int[] Arr = { 1, 2, 3 };
        //Console.WriteLine(sumArr(ref Arr));
        //Console.WriteLine(Arr[0]);
        #endregion

        //int a = 5, b = 6;
        //int sum, mul;
        //sumMul(a, b,out sum,out  mul);
        //Console.WriteLine(sum);
        //Console.WriteLine(mul);

        //sumMul(a, b, out sum, out _);
        //Console.WriteLine(sum);



      


    }

}

