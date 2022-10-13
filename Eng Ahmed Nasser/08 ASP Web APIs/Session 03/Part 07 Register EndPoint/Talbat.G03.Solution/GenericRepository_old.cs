//#region MyRegion
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Talabat.BLL.Interfaces;
//using Talabat.DAL.Data;
//using Talabat.DAL.Entities;

//namespace Talabat.BLL.Repository
//{
//    // p5.4. ...coming from Interfaces\IGenericRepository.cs
//    // p5.4.1 make the class implement IGenericRepository
//    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
//    {


//        // p5.4.2 to GetByIdAsync and GetAllAsync we should communicate with the database
//        //       so se will create constructor and inject StoreContext
//        //       - then "create and assign field"
//        private readonly StoreContext _context;
//        public GenericRepository(StoreContext context)
//        {
//            _context = context;
//        }

//        // 5.4.3 implement the functions
//        public async Task<T> GetByIdAsync(int id)
//            => await _context.Set<T>().FindAsync(id);


//        // 5.4.4 these functions is common functions that all entities use
//        //       so we would make interfaces and classes for each entity all of them have
//        //       these functions and its own fuctions
//        //       - but in our business these function are sufficient so we wouldn't make any interfaces and classes for entities


//        // 5.4.6 create ProductController controller in Talabat.API/Controller
//        // 5.4.7 go to the controller...
//        public async Task<IReadOnlyList<T>> GetAllAsync()
//        {
//            // - the product in the relatoin between ProductBrand or ProductType is 1
//            //   so when we get the ProductBrand and ProductType it well be null, the solution 
//            //   is using "include()"

//            // - but ths when the "T" is product so we wil add a condition
//            // - but there is a problem that when ever the "Product" has another Entity we will add
//            //   another include() for this entity and this doesn't apply
//            //   the principle "open for extension close for modification"(clean code)
//            // - so we will use a design pattern called Specification
//            if (typeof(T) == typeof(Product))
//            {
//                return (IReadOnlyList<T>)await _context.Set<Product>()
//                    .Include(P => P.ProductBrand).Include(P => P.ProductType).ToListAsync();
//            }

//            // so we will make this query generic
//            // 5.4.8 create Talabat.BLL/Specificions
//            // 5.4.9 create Talabat.BLL/Specificions/ISpecificions
//            // 5.4.10 go to Talabat.BLL/Specificions/ISpecificions ...



//            return await _context.Set<T>().ToListAsync();
//        }




//    }
//}

//#endregion