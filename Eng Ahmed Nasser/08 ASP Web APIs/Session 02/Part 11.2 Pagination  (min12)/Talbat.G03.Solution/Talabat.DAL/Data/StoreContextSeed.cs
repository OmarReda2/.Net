using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.DAL.Data
{
    public class StoreContextSeed
    {
        // //p4.3 create Data/SeedData and put the json files that will be added to the database
        // //p4.4 create function that will add the data to the database
        // //- we will pass to the function parameter 2 variabless 
        //     StoreContext: to add the seeded data to the database
        //     IloggerFactory: to throw an exception in the console
        public static async Task seedAsync(StoreContext context, ILoggerFactory LoggerFactory)
        {
            try
            {

                // // we would check if the there any data in the database
                //       it wouldn ot excute these operations
                if (!context.ProductBrand.Any())
                {
                    // //p4.5 read the data
                    var brandsData = File.ReadAllText("../Talabat.DAL/Data/SeedData/brands.json");

                    // //p4.6 convert the json to list of ProductBrand
                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

                    // //p4.7 add the list we created in the context by foreach
                    foreach (var brand in brands)
                    {
                        context.Set<ProductBrand>().Add(brand);
                    }
                    await context.SaveChangesAsync(); 
                }

                // //p4.8 repe at the steps from p4.5 to p4.7 for the ProductType and Product 
                if (!context.ProductType.Any())
                {
                    var typesData = File.ReadAllText("../Talabat.DAL/Data/SeedData/types.json");
                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
                    foreach (var type in types)
                    {
                        context.Set<ProductType>().Add(type);
                    }
                    await context.SaveChangesAsync();
                }

                //if (!context.Product.Any())
                //{
                //    var productsData = File.ReadAllText("../Talabat.DAL/Data/SeedData/products.json");
                //    var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                //    foreach (var product in products)
                //    {
                //        context.Set<Product>().Add(product);
                //    }
                //    await context.SaveChangesAsync();
                //}
            }
            // //p4.8 use the LoggerFactory that we defined to create the error in the console
            catch (Exception ex)
            {
                var logger = LoggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex, ex.Message);
            }

            // //p4.9 go to the Program ...
            // - as we will use this function there
        }
    }
}
