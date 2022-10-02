using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.BLL.Specifications;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Interfaces
{
    // p5. coming from text1.cs
    // p5.1 make IGenericRepository generic"<T>" and making the "T" implement the BaseEntity
    //      - so the T would be baseEntity or any class implementing it (Product, ProductBrand & ProductType)
    public interface IGenericRepository<T> where T: BaseEntity
    {
        // p5.2 add the five common behavior but we will use 2 of them now
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync(); // we would use IReadOnlyList instead of IEnummerable

        // p5.3 create Repository/GenericRepository.cs to implement this interface
        // p5.4 go to Repository/GenericRepository.cs ...   







        // 5.4.18... coming from Repository/GenericRepository
        // 5.4.19 creating the fucntion that use the Specifacation design pattern
        Task<T> GetByIdWithSpecAsync(ISpecification<T> spec);
        Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> spec);
        //5.4.20 go to GenericRepository to implement the functions 
    }
}
