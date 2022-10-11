namespace Talbat.API.DTO
{
    // ... p1.1 coming from TextFile.cs
    public class ProductToReturnDTO
    // p1.2 copy the the prop from Talabat.DAL\Entities\Product to here
    // - we would not imp the BaseEntity as it is not an a table in db, it is "dto"
    // p1.3 install AutoMappper package in API
    // p1.4 create Helper\MappingProfile.cs
    // - as we need to map the entity to dto
    // - so we will put mapping config in MappingProfile
    // p1.4 create Helper\MappingProfile.cs 
    // p1.4 go to Helper\MappingProfile.cs ...
    
    {

        public int id { get; set; }
        // - as the baseEntity have the id prop (common prop) so we will id

        public string Name { get; set; }
        public string Descrption { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }

        public string ProductBrand { get; set; } 
        // - make the type string instead as this will be only be visualized in the frontend
        // - if we dont make the prev step it would be represented as an object
        //   so in the whole data it will represented as an instead obj 
        
        public int ProductBrandId { get; set; } 

        public string ProductType { get; set; }
        // - make the type string instead
        public int ProductTypeId { get; set; } 
    }
}
