#region Problem 01
//Console.WriteLine("Please enter a number");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine($"the number is {num}");
#endregion


#region problem 02
//Console.WriteLine("Please enter a number");
//int num = int.Parse(Console.ReadLine());

//if (num % 3 == 0)
//{
//    Console.WriteLine("yes");
//} else {
//    Console.WriteLine("no");
//}
#endregion


#region problem 03
//Console.WriteLine("Please insert the 1st number");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Please insert the 2nd number");
//int num2 = int.Parse(Console.ReadLine());

//if(num1 > num2)
//{
//    Console.WriteLine($"the 1st '{num1}' is greater than 2nd '{num2}'");
//}else if(num1 < num2)
//{
//    Console.WriteLine($"the 2nd '{num2}' is greater than 1st '{num1}'");

//}
//else
//{
//    Console.WriteLine($"the 1st number '{num1}' equals the 2nd '{num2}'");
//}
#endregion


#region problem 04
//Console.WriteLine("Please enter a number");
//int num = int.Parse(Console.ReadLine());

//if(num < 0)
//{
//    Console.WriteLine("negative");
//}else if(num > 0 )
//{
//    Console.WriteLine("positve");
//}
//else
//{
//    Console.WriteLine("zer0");
//}
#endregion


#region problem 05
//Console.WriteLine("Please insert 3 numbers");
//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int num3 = int.Parse(Console.ReadLine());

//if(num1 > num2 && num1 > num3)
//{
//    if(num2 > num3)
//    {
//        Console.WriteLine($"max: {num1}\nmin: {num3}");
//    }
//    else
//    {
//         Console.WriteLine($"max: {num1}\nmin: {num2}");
//    }

//}
//else if (num2 > num1 && num2 > num3)
//{
//    if (num1 > num3)
//    {
//        Console.WriteLine($"max: {num2}\nmin: {num3}");
//    }
//    else
//    {
//        Console.WriteLine($"max: {num2}\nmin: {num1}");
//    }

//}
//if (num3 > num1 && num3 > num2)
//{
//    if (num2 > num1)
//    {
//        Console.WriteLine($"max: {num3}\nmin: {num1}");
//    }
//    else
//    {
//        Console.WriteLine($"max: {num3}\nmin: {num2}");
//    }

//}
//else
//{
//    Console.WriteLine("Please insert different numbers");
//}
#endregion


#region problem 06 
//Console.WriteLine("Please insert a number");
//int num = int.Parse(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("even");
//}
//else
//{
//    Console.WriteLine("odd");
//}
#endregion


#region problem 07
//Console.WriteLine("Please insert a Character");
//char c = char.Parse(Console.ReadLine());

//if(c == 'a' || c == 'e'|| c == 'i' || c == 'o' || c == 'u')
//{
//    Console.WriteLine("vowel");
//}
//else
//{
//    Console.WriteLine("constant");
//}
#endregion


#region problem 08

#endregion


#region problem 09
//Console.WriteLine("please enter a number");
//int num = int.Parse(Console.ReadLine());

//for (int i = 1; i <= 12; i++)
//{
//    Console.WriteLine($"{num * i}");
//}
#endregion


#region problem 10
//Console.WriteLine("please enter a number");
//int num = int.Parse(Console.ReadLine());

//for (int i = 2; i < num; i++)
//{
//    if(i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//    else
//    {
//        continue;
//    }
//}
#endregion


#region problem 11
//Console.WriteLine("please enter the base number");
//int baseNum = int.Parse(Console.ReadLine());

//Console.WriteLine("please enter the power number");
//int powerNum = int.Parse(Console.ReadLine());

//int result = 1;
//for (int i = 0; i < powerNum; i++)
//{
//    result *= baseNum;
//}

//Console.WriteLine(result);

#endregion


#region problem 12
//Console.WriteLine("enter marks of 5 subjects");
//int[] marks = new int[5];

//for (int i = 0; i < marks.Length; i++)
//{
//    Console.WriteLine($"subject {i + 1}:");
//    marks[i] = int.Parse(Console.ReadLine());
//}



//int total = 0;
//for(int i = 0; i < marks.Length; i++)
//{
//    total += marks[i];
//}

//Console.WriteLine($"total: {total} \naverage: {total/5} \nprecentage:{(total * 100)/500}");
#endregion


#region problem 13 , 15
//Console.WriteLine("enter the month number");
//int month = int.Parse(Console.ReadLine());

//switch (month)
//{
//    case 1 or 3 or 5 or 7 or 8 or 10 or 12:
//        Console.WriteLine("Days in month 31");
//        break;
//    case 4 or 6 or 9 or 11:
//        Console.WriteLine("Days in month 30");
//        break;
//    case 2:
//        Console.WriteLine("Days in month 29 or 28");
//        break;

//    default:
//        Console.WriteLine("enter a valid number");
//        break;
//}
#endregion


#region problem 14
//int[] arr = new int[5];
//int total = 0;
//int prec;

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine($"enter subject {i + 1}:");
//    arr[i] = int.Parse(Console.ReadLine());

//    total += arr[i];
//}

//prec = (total * 100) / 500;

//switch (prec) {
//    case (>= 90):
//        Console.WriteLine("A");
//        break;

//    case (>= 80):
//        Console.WriteLine("B");
//        break;

//    case (>= 70):
//        Console.WriteLine("C");
//        break;

//    case (>= 60):
//        Console.WriteLine("D");
//        break;

//    case (>= 40):
//        Console.WriteLine("E");
//        break;

//    case ( < 40):
//        Console.WriteLine("F");
//        break;
//}

#endregion


#region problem 16
//Console.WriteLine("enter a number");
//int num = int.Parse(Console.ReadLine());

//switch (num)
//{
//    case  > 0:
//        Console.WriteLine("positive");
//        break;

//    case < 0:
//        Console.WriteLine("negative");
//        break;

//    case  0:
//        Console.WriteLine("zero");
//        break;

//    default:
//        Console.WriteLine("enter a number");
//        break;

//}

#endregion


#region problem 17
//Console.WriteLine("enter the first number");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("enter the operator (+, -, *, /, or %)");
//char op = char.Parse(Console.ReadLine());

//Console.WriteLine("enter the second number");
//int num2 = int.Parse(Console.ReadLine());

//int result;

//switch (op)
//{
//    case '+':
//        result = num1 + num2;
//        Console.WriteLine($"result: {result}");
//        break;

//    case '-':
//        result = num1 - num2;
//        Console.WriteLine($"result: {result}");
//        break;

//    case '*':
//        result = num1 * num2;
//        Console.WriteLine($"result: {result}");
//        break;

//    case '/':
//        result = num1 / num2;
//        Console.WriteLine($"result: {result}");
//        break;

//    case '%':
//        result = num1 % num2;
//        Console.WriteLine($"result: {result}");
//        break;

//    default:
//        Console.WriteLine("enter a valid opertor or number");
//        break;
//}
#endregion


#region problem 18 , 19
//Console.WriteLine("enter the string or number u want to reverse");
//string str = Console.ReadLine();
//char[] charArr = new char[str.Length];



//for (int i = 0; i < str.Length; i++)
//{
//    charArr[i] = str[str.Length - i - 1];
//}

//charArr.ToString();
//Console.WriteLine(charArr);
#endregion