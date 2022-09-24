using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.DAL.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Descrption { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }


        public ProductBrand ProductBrand { get; set; } // Navigational prop (relation)
        public int ProductBrandId { get; set; } // foriegn key for Productbrand
       

        public ProductType ProductType { get; set; }  // Navigational prop (relation)
        // only creating one navigational prop as the entity framework can 
        // under stand the other relation (Product(1) - (m)ProductBrand/ProductType)
        public int ProductTypeId { get; set; } // foriegn key for Productype
    }
}
