using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Data.Config;
using Talabat.DAL.Entities;

namespace Talabat.DAL.Data
{
    // continueing from the last step in ProjectStepsAndNotes/TextFile1.cs
    // 1- implement DbContext 
    public class StoreContext:DbContext
    {
        //2- Create Constructor 
        //3- inject DbContextOptions<StoreContext>
        //4- allow dependency injection in Startup
        //5- before going to startup add project reference for Bll to DAL, API to Bll
        //6- Go to Startup...
        //7- ... when creating object from StoreContext which has constocter depend on DI(DbContextOptions<StoreContext> options)
        //  - the object well be created in runtime as we has defined in Startup to allow creating object that
        //    has DI constructor
        //  - the Startup passes options to options defined here(which has now the ConnectionString)
        //  - the options will be passed to the base()/DbContext which have function OnConfiguring() 
        //    that will create our database
        public StoreContext(DbContextOptions<StoreContext> options):base(options)
        {
            
        }
        // - we used to override OnConfiguring() and use UseSqlServer("")
        // - but now it will work with it self in the base() but we should passes the ConnectionString
        //   to the base() by the options
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("")
        }*/




        //8- making Tables Product,ProductType,ProductBrand
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<ProductBrand> ProductBrand { get; set; }



        //9- making Data/Config to make the validation by fluent API
        // - making Data/Config/ProductConfiguration.cs
        //10- go to Data/Config/ProductConfiguration.cs ...
        //...11- coming from Data/Config/ProductConfiguration.cs
        //12- override OnmodelCreating() to add the configuration which has the prop/validation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //13- put modelBuilder to make the configuration
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //modelBuilder.ApplyConfiguration(new OrderConfiguration()); // - Order configuration is imposed here


            //- we can add all configuration all in on time prefered as a clean code
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //- any class implement IEntityTypeConfiguration
                                                                                           //  it will put it here

            //14- add migration
            //- install package where the connection string is(Talabat.API/Startup)
            //- install "Microsoft.EntityFrameworkCore.Tools" Package in Talabat.API
            //- insure that Talabat.API is the startup project (set as startup project "Right click")
            //- open Package Manager Console 
            //- Default project: DAL
            //- add migrtion in "Talabat.DAL" by typing "Add-Migration  initialCreate -o Data/Migrations"
            //  , "-o Data/Migration": means that th output will be in Data folder

        }
    }
}
