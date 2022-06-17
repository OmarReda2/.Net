#region 
//int x = 10;
//int y = x;
//x++;
//Console.WriteLine(x);
//Console.WriteLine(y);
#endregion




#region
//float x = 1.2f
//double x = 1.2;
//decimal x = 1.2m;
//int x = 100_000_000;
//Console.WriteLine(x);
#endregion




#region
//int x = 10;
//long y = x;

//long x2 = 7777777777;
//Console.WriteLine(x2);
//int y2 = (int)x2;
//Console.WriteLine(y2);





//long x3 = 7777777777;
//Console.WriteLine(x3);

//checked
//{
//    int y3 = (int)x3;
//    Console.WriteLine(y3);
//}

//unchecked
//{
//    int y3 = (int)x3;
//    Console.WriteLine(y3);
//}





//int x4 = 4;
//x4 = int.Parse(Console.ReadLine());
//Console.WriteLine(x4);

//Console.WriteLine("Please enter ur name");
//string name = Console.ReadLine();

//Console.WriteLine("Please enter ur age");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine("Hello " + name);
//Console.WriteLine("ur age is " + age);

//long y = Convert.ToInt32(Console.ReadLine());
#endregion




#region
//int x = 1;
//int y = 2;
//string msg = String.Format("the sum of equation is {0} + {1} + {3} = {2}",x,y,x + y);
//string msg = $"the sum of equation is {x} +  {y} = {x + y}";
//Console.WriteLine(msg);
#endregion



#region
//int x;
//x = int.Parse(Console.ReadLine()); 

//if(x == 1)
//{
//    Console.WriteLine("Jan");
//}else if(x == 2)
//{
//    Console.WriteLine("Feb");
//}else
//{
//    Console.WriteLine("Out of range");
//}
#endregion


#region
//Console.WriteLine("Please choose 1, 2 or 3");
//int x;
//x = int.Parse(Console.ReadLine());

//switch (x)
//{
//    case 1:
//        Console.WriteLine("opt1");
//        Console.WriteLine("opt2");
//        Console.WriteLine("opt3");
//        break;
        
//    case 2:
//        Console.WriteLine("opt1");
//        Console.WriteLine("opt2");
//        break ;
//    case 3:
//        Console.WriteLine("opt1");
//        break;


//    default:
//            Console.WriteLine("out of options");
//            break;
        

//}



Console.WriteLine("Please choose 1, 2 or 3");
int x;
x = int.Parse(Console.ReadLine());

switch (x)
{
    case 1:
       goto case 2;
        Console.WriteLine("opt3");
        
        
    case 2:
        goto case 3;
        Console.WriteLine("opt2");
       
    case 3:
        Console.WriteLine("opt1");
        break;


    default:
            Console.WriteLine("out of options");
            break;
        

}
#endregion





























