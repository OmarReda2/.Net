using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Interfaces
{
    // ... p3.1
    public interface IBasketRepository
    {
        // p3.2
        Task<CustomerBasket> GetCustomerBasket(string basketId);

        Task<CustomerBasket> UpdateCustomerBasket(CustomerBasket basket);

        Task<bool> DeleteCustomerBasket(string basketId);

        //p3.3 create Repository.BasketRepository
        //p3.3 go to Repository.BasketRepository ...

    }
}
