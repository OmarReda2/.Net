
#region 
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}





//int x;
//bool flag = true;

//do
//{
//    Console.WriteLine("please enter an even number:");
//    flag = int.TryParse(Console.ReadLine(), out x);
//} while (x % 2 == 1 || !flag);












//string name = "omar";
//foreach (var item in name)
//{
//    Console.WriteLine(item);
//}

//for (int i = 0; i < name.Length; i++)
//{
//    Console.WriteLine(name[i])
//}

#endregion


#region 
//int[] numbers = new int[3];

//int[] numbers2;
//numbers2 = new int[3];
//numbers2[0] = 0;
//numbers2[1] = 1;    
//numbers2[2] = 2;
//Console.WriteLine(numbers2[0]);

//int[] numbers3 = new int[3] { 1, 2, 3};

//int[] numbers4 = new int[] { 1, 2, 3, 4 };

//int[] numbers5 = {1, 2, 3, 4, 5 };
//Console.WriteLine($"length: {numbers5.Length} \ndimensions:{numbers5.Rank}");
//for(int i = 0; i < numbers5.Length; i++)
//{
//    Console.WriteLine(numbers5[i]);
//}



//int[] Arr = {1, 2, 3};
//int[] Arr2 = {4, 5, 6};

//Arr2 = Arr;
//Arr[0] = 11;

//Console.WriteLine(Arr[0]);
//Console.WriteLine();

//Console.WriteLine(Arr.GetHashCode());
//Console.WriteLine(Arr2.GetHashCode());
//Console.WriteLine("-------------");

//Arr2 = (int[])Arr.Clone();
//Console.WriteLine(Arr.GetHashCode());
//Console.WriteLine(Arr2.GetHashCode());





//int[] Arr3 = { 4, 8, 2, 5, 7, 1, 9 };
//Array.Reverse(Arr3);

//for (int i = 0; i < Arr3.Length; i++)
//{
//    Console.WriteLine(Arr3[i]);

//}
#endregion


#region 
//int[,] arr = new int[3, 5];
//bool flag = true;

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    Console.WriteLine($"Student No.{i + 1}");
//    for(int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.WriteLine($"mark {j+1}");
//        arr[i,j] = int.Parse(Console.ReadLine());
//    }
//}



//int[,] arr = new int[3, 5];
//bool flag = true;
//int j = 0;

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    Console.WriteLine($"Student No.{i + 1}");
//    while (j < arr.GetLength(1))
//    {
//        Console.WriteLine($"mark {j + 1} :");
//        flag = int.TryParse(Console.ReadLine(), out arr[i, j]);
//        j = flag ? ++j : j;
//    }
//    j = 0;
//    Console.WriteLine("---------------------");
//}




#endregion


#region 
//int x = 10;
//x++;

//Object obj = new object();
//obj = x;

//Console.WriteLine(obj);
//Console.WriteLine(x);

//int y = (int)obj;
#endregion


#region 
//int x = null;
//int? x = null;

//int y = 10;
//y = (int)x;

//if(x != null)
//{
//    y = (int)x;
//}


//if (x.HasValue)
//{
//    y = x.Value;
//}

//y = x.HasValue ? x.Value : 0;

//y = x ?? 0;
#endregion

#region 
//double num = default;
//Console.WriteLine(num);

int[] arr = default;
//for (int i = 0; (arr != null) && (i < arr.Length); i++)
//{
//    Console.WriteLine(i);
//}

for(int i = 0; i < arr?.Length; i++)
{
    Console.WriteLine(i);
}

//int? length = arr?.Length;
int length = arr?.Length ?? 11;
Console.WriteLine(length);


#endregion