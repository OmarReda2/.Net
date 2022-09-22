using Database_First2.Context;
using Database_First2.Entities;
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
                #endregion








                #region Write Raw SQL
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
                //SqlParameter id = new SqlParameter() { Direction = ParameterDirection.Output };
                //var result = context.Products.FromSqlRaw("exec Sp_ProductID @id output", id);
                #endregion












                #region Lazy Loading
                //var result =
                //                  //from p in context.Products.Include(p => p.Category).Include(p => p.Supplier)
                //                  //from p in context.Products.Include(p => p.Category).ThenInclude(C => C.Customers)
                //                  //(from p in context.Products // if we use Proxies packege it well load the Category (navigationProp/virtual/forgienkey/lazyLoadingDisable)
                //                  (from p in context.Products.Include(p => p.Category)
                //                   where p.UnitsInStock == 0
                //                   select p).ToListAsync();

                //foreach (var item in result.Result)
                //{
                //    //Console.WriteLine($"{item.ProductName} :: {item.Category?.CategoryName ?? "NA"} ::" +
                //    //    $"{item.Supplier?.CompanyName ?? "NA"}");

                //    Console.WriteLine($"{item.ProductName} :: {item.Category?.CategoryName ?? "NA"} ::"); // if we use proxies packege it well load the Category (navigationProp/virtual/forgienkey/lazyLoadingDisable) 
                #endregion










                #region Remote Vs Local
                //// // Local
                //context.Products.Load();
                //if(context.Products.Local.Any(p => p.UnitsInStock == 0))
                //    Console.WriteLine("There are out of stock Products");
                //// // Remote
                //else if(context.Products.Any(p => p.UnitsInStock == 0))
                //         Console.WriteLine("There are out of stock Products");



                // // Local
                context.Products.Load();
                var result = context.Find<Product>(10);
                // // Remote
                result = context.Products.Find(10);
                Console.WriteLine(result?.ProductName ?? "NA");
                #endregion
            }



        }
    }
}
