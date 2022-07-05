using Database_First2.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Database_First2
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (NORTHWNDContext context = new NORTHWNDContext()) 
            {
                #region Stored Procedure
                //var procedureContext = new NORTHWNDContextProcedures(context);
                //var products = procedureContext.SalesByCategoryAsync("Beverages", "1998");

                //foreach (var item in products.Result)
                //{
                //    Console.WriteLine(item);
                //}










                // // FromSqlRaw (To write SQL in C#)
                //var result = context.Categories.FromSqlRaw("select * from Categories").ToListAsync();
                //foreach (var item in result.Result)
                //{
                //    Console.WriteLine($"{item.CategoryName} :: {item.Description} :: " +
                //        $"{item.CategoryId} :: ${item.Products.Count}");
                //}

                // // FromSqlInterpolated
                //var result = context.Products.FromSqlInterpolated($"select top({3})* from Products").ToListAsync();
                //foreach (var item in result.Result)
                //{
                //    Console.WriteLine($"{item.ProductName} :: {item.UnitPrice} ");
                //}

                // // SQLParameter
                SqlParameter id = new SqlParameter() { Direction = ParameterDirection.Output };
                var result = context.Products.FromSqlRaw("exec Sp_ProductID @id output", id);
                #endregion
            }
        }
    }
}