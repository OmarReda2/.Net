using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.BLL.Specifications;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Interfaces
{
    
    public interface IGenericRepository<T> where T: BaseEntity
    {
        
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync(); 

        Task<T> GetByIdWithSpecAsync(ISpecification<T> spec);
        Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> spec);

        // ...p12.19 coming from Product/ProductWithFIltersWithCountSpecification
        // 12.20 add GetCountAsync() as we wnt to calc the count of products
        Task<int> GetCountAsync(ISpecification<T> spec);
       
        // p12.21 go to Repository/GenericRepository.cs to imp the function...   






    }
}
