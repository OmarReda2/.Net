using AutoMapper;
using Talabat.DAL.Entities;
using Talbat.API.DTO;

namespace Talbat.API.Helper
{
    // ... p1.4 coming from DTO/ProductToReturnDTO.cs
    public class MappingProfile:Profile
    {
        // p1.5 create ctor and map entities to it's dto
        // to see the steps of p1 please check the part before
        public MappingProfile()
        {
            CreateMap<Product, ProductToReturnDTO>()
                .ForMember(d => d.ProductBrand, O => O.MapFrom(S => S.ProductBrand.Name))
                .ForMember(d => d.ProductType, O => O.MapFrom(S => S.ProductType.Name))
                // ... p1.15 coming from ProductPictureUrlResolver
                // p1.16 map the pictureUrl
                .ForMember(d => d.PictureUrl, O => O.MapFrom<ProductPictureUrlResolver>());

            //p1.17 create Talabat.API/wwwroot
            // - as after the mapping we want the images to be shown
            //   so we will add images folder in wwwrooot

            //p1.18 add "app.UseStaticFile" Middleware in Startup
            // go to Startup...


        }
    }
}
