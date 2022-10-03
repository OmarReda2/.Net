using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.BLL.Interfaces;
using Talabat.BLL.Specifications;
using Talabat.DAL.Data;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Repository
{
    // p5.4. ...coming from Interfaces\IGenericRepository.cs
    // please go to  ProjectStepsAndNotes/GenericRepository to complete steps after 5.4

    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _context;
        public GenericRepository(StoreContext context)
        {
            _context = context;
        }

        // 5.4.17 coming from SpecificationsEvaluator
        // 5.4.18 use the GetQuery that (will build the query)but we will but it in a private funtion
        // 5.4.18 go to interfaces/IGenerincRepository.cs as we will add the functions with specifications ...
        private IQueryable<T> ApplySpecifications(ISpecification<T> spec)
        {
            return SpecificationsEvaluator<T>.GetQuery(_context.Set<T>(), spec);
        }

        // ... 5.4.21 coming from IGenericRepository
        // 5.4.22 imp the functions
        public async Task<T> GetByIdWithSpecAsync(ISpecification<T> spec)
        {
            return await ApplySpecifications(spec).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> spec)
        {
            return await ApplySpecifications(spec).ToListAsync();
        }

        // 5.4.23 go to controlller to update the endpoints/actions with the functions Specfication applyied









        public async Task<T> GetByIdAsync(int id)
            => await _context.Set<T>().FindAsync(id);


        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
