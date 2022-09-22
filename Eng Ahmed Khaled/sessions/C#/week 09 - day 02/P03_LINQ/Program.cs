#region LINQ
//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//var result = Enumerable.Where(numbers, (n) => n % 2 == 0);
//result = numbers.Where((n) => n % 2 == 0);





//result = from n in numbers
//         where n % 2 == 0
//         select n;

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}




//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//var result = numbers.Where((n) => n % 2 == 0);

//numbers.Remove(2);
//numbers.AddRange(new int[] { 20, 21, 22, 23, 24, 25 });
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}





List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var result = numbers.Where((n) => n % 2 == 0).ToList();

numbers.Remove(2);
numbers.AddRange(new int[] { 20, 21, 22, 23, 24, 25 });
foreach (var item in result)
{
    Console.WriteLine(item);
}
#endregion