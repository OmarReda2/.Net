using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.DAL.Data.Config
{
    //... 10. coming from StoreContext
    // - 10.1 Implement Interface IEntityTypeConfiguration<Product>
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        // - 10.2 adding properties
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //builder.Property(P => P.id).IsRequired();  // - we dont need it the id  is the primary key "By Convention"
            builder.Property(P => P.Descrption).IsRequired();
            builder.Property(P => P.Price).HasColumnType("decimal(18,2)");
            builder.Property(P => P.PictureUrl).IsRequired();

            // - WeakReference would not use these property as it well be defined by convention
            //builder.HasOne(P => P.ProductBrand).WithMany().
            //    HasForeignKey(P => P.ProductBrandId);
            //builder.HasOne(P => P.ProductType).WithMany().
            //    HasForeignKey(P => P.ProductType);
            
        }
        //10.3 Adding this configuration to the OnModelCreating in the storeContext
        // 10.4 - back to StoreContext...
    }
}
