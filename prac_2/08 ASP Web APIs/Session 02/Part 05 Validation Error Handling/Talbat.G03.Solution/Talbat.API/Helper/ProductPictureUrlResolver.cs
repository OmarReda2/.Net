using AutoMapper;
using Microsoft.Extensions.Configuration;
using Talabat.DAL.Entities;
using Talbat.API.DTO;

namespace Talbat.API.Helper
{
    //... p1.1 coming from TextFile.cs

    public class ProductPictureUrlResolver : IValueResolver<Product, ProductToReturnDTO, string>
    // p1.2 implement the IValueResolver from the AutoMapper package
    //      as the we actually map the PictureUrl "images/products/sb-ts1.png"
    //      to "https/5001/images/products/sb-ts1.png"
    // - IValueResolver<source, destination, type>
    // p1.3 imp the interface
    {
        private readonly IConfiguration _configuration;

        //p1.12
        public ProductPictureUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }




        public string Resolve(Product source, ProductToReturnDTO destination, string destMember, ResolutionContext context)
        {
            

            //p1.4 check if the pictureUrl is null or not
            if (!string.IsNullOrEmpty(source.PictureUrl)) // if its it null resolving
            {
                //p1.5 stick to picturUrl the baseUrl(https://localhost:5001/)
                // - so we will go to appsetting and define the base url ...

                // ... p1.10 coming from appsetting (mistake of steps, the right: p1.6)
                // - we want the appsetting to be visiblt to "ProductPictureUrlResolver"
                // - so we will inject configuration in the ctor
                //   as we make in the startup when we want the appseeting to be visible on the Startup
                // p1.11 create ctor and inject configuration(dont forget asssign field step)

                //p1.13 return the mapped url 
                return $"{_configuration["ApiUrl"]}{source.PictureUrl}";

                //as this a mapping we would to configre this map in the Helper/MappingProfile
                //p1.14 go to Helper/MappingProfile ...
            }

            return null;
        }
    }
}
