using System;

namespace Demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (UniversityContext context = new UniversityContext())
            {
                Teacher teacher = new Teacher() { Name = "Ahmed Khaled", HireDate = new DateTime(2021, 10, 2) };
                Student student = new Student() { Name = "Ahmed Naser", EnrollDate = new DateTime(2021, 10, 1) };



                #region TPCC
                //context.Teachers.Add(teacher);
                //context.Students.Add(student);
                //context.SaveChanges();

                //foreach (var item in context.Teachers)
                //{
                //    Console.WriteLine($"{item.Id} :: {item.Name} :: {item.HireDate}");
                //}

                //foreach (var item in context.Students)
                //{
                //    Console.WriteLine($"{item.Id} :: {item.Name} :: {item.EnrollDate}");
                //} 
                #endregion





                #region TPH
                //context.Teachers.Add(teacher);
                //context.Students.Add(student);
                //context.SaveChanges();


                // // One Dbset (Base Class)
                foreach (var item in context.Persons.OfType<Teacher>())
                {
                    Console.WriteLine($"{item.Id} :: {item.Name} :: {item.HireDate}");
                }

                foreach (var item in context.Persons.OfType<Student>())
                {
                    Console.WriteLine($"{item.Id} :: {item.Name} :: {item.EnrollDate}");
                }
                #endregion
            }



        }
    }
}