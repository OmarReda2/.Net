using AutoMapper;
using Talabat.DAL.Entities;
using Talbat.API.DTO;

namespace Talbat.API.Helper
{
    // ... p1.4 coming from DTO/ProductToReturnDTO.cs
    public class MappingProfile:Profile
    {
        // p1.5 create ctor and map entities to it's dto
        public MappingProfile()
        {
            CreateMap<Product, ProductToReturnDTO>()// create the product mapping
                .ForMember(d => d.ProductBrand, O => O.MapFrom(S => S.ProductBrand.Name)) // d stands for destination or the data will be in clientSide/api (ProductToReturnDTO)
                .ForMember(d => d.ProductType, O => O.MapFrom(S => S.ProductType.Name));
            // - as we need to map the ProductBrand(object) to ProductBrand.Name(string) as well as ProductType to avoid confusions and errors
            

            // - we would not create the reverse mapping(from dto to entities)
            //   as we would not add(POST) products (as the entites in frontend would be as dto we would to map it to entities if we need to post)

            // - p1.6 go to ProductController and inject AutoMapper
        }
    }
}
