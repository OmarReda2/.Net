using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int? id);
        IEnumerable<T> GetAll();
        int Add(T obj);
        int Update(T obj);
        int Delete(T obj);
    }
}
