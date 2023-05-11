using App1.Context;
using App1.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace App1
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (EnterpriseDbContext context = new EnterpriseDbContext())
            {
                Employee E01 = new Employee() { Name = "John", Age = 25, Salary = 1000 };
                Employee E02 = new Employee() { Name = "Mary", Age = 25, Salary = 2000 };

                Departement D01 = new Departement() { DeptName = "IT", YearOfCreation = DateTime.Now };
                Departement D02 = new Departement() { DeptName = "HR", YearOfCreation = DateTime.Now };



                // //insert
                // // Adding Methods
                //context.Departements.Add(D01);
                //context.Add(E01);
                //context.Set<Employee>().Add(E01);
                //context.Entry(E01).State = EntityState.Added;

                //Console.WriteLine(context.Entry(E01).State);
                //context.Employees.Add(E01);
                //Console.WriteLine(context.Entry(E01).State);
                //context.SaveChanges();
                //Console.WriteLine(context.Entry(E01).State);

                //context.Add(E02);
                //context.SaveChanges();

                //context.Add(D01)
                //context.AddRange(D01, D02);
                //context.SaveChanges();





                // // Rettrive
                //var result = context.Departements.Where(D => D.DeptName == "IT").FirstOrDefault();
                //Console.WriteLine(result.YearOfCreation);





                // // Update
                //var result = context.Departements.Where(D => D.DeptName == "IT").FirstOrDefault();
                //result.DeptName = "Sales";
                //Console.WriteLine(context.Entry(result).State);
                //context.SaveChanges();






                // // Delete
                var result = context.Employees.Where(e => e.EmpId == 2).FirstOrDefault();
                context.Employees.Remove(result);
                Console.WriteLine(context.Entry(result).State);
                context.SaveChanges();




            }
        }
    }
}