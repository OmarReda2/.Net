using P02;
//// // implicitly local variable => 
//var number = 123.456;
//Console.WriteLine(number.GetType().Name);



//// // Extension Methode
//int x = 12345;
//int y = ExMethods.Mirror(x);
//Console.WriteLine(y);

//y = x.Mirror();
//Console.WriteLine(y);

//float a = 12.44f;
//float b = a.Mirror();
//Console.WriteLine(b);








// // Anonymous type
//Employee employee = new Employee() { Id = 1, Name = "Ahmed" };
//object employee = new { Id = 1, Name = "Ahmed" };
var emp01 = new { Id = 1, Name = "Ahmed", Salary = 3000 };
Console.WriteLine(emp01.Id);
Console.WriteLine(emp01.GetType().Name);
Console.WriteLine(emp01);
//employee.Id = 10; // Immutable

var emp02 = new { Id = 2, Name = "Ali", Salary = 3000 };
Console.WriteLine(emp02.GetType().Name);




