#region problem1
//Console.WriteLine("enter array length:");
//int length = int.Parse(Console.ReadLine());
//int[] arr = new int[length];

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine($"element No.{i + 1}");
//    arr[i] = int.Parse(Console.ReadLine());
//}


////int[,] arr2 = new int[length,2];
//int maxLength = 0;
//int finalMaxLength = 0;
//int maxNum = 1;

//int lastPosition = 0;

//for (int i = 0; i < arr.Length; i++)
//{

//    for (int j = 1; j < arr.Length; j++)
//    {
//        if (arr[i] == arr[j])
//        {
//            lastPosition = j;
//        }
//    }

//    maxLength = lastPosition - i - 1;



//    if (i == 0)
//    {
//        maxNum = arr[i];
//        finalMaxLength = maxLength;
//    }


//    if ((maxLength > finalMaxLength) && (i != 0))
//    {
//        finalMaxLength = maxLength;
//        maxNum = arr[i];
//    }

//    maxLength = 0;
//}

//Console.WriteLine("=======================================");
//Console.WriteLine($"the number that has longest distance is '{maxNum}' \nand the distance is '{finalMaxLength}' element");
#endregion



#region problem2
Console.WriteLine("enter a sentence");

string text = Console.ReadLine();
string[] result = text.Split(" ");

Array.Reverse(result);
Console.WriteLine(String.Join(" ", result));

#endregion








fgdf


