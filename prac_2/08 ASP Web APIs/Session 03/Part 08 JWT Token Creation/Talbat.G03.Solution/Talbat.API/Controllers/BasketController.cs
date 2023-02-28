using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Talabat.BLL.Interfaces;
using Talabat.DAL.Entities;

namespace Talbat.API.Controllers
{
   // ... p4.1
   // p4.2 
    public class BasketController : BaseController
    {
        private readonly IBasketRepository _basketRepository;

        public BasketController(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }

        // p4.3 go to Talbat.API.Extensions.ApplicationServiceExtension(Startup) to allow DI ...
        // ... p4.5
        // p4.5
        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetBasket(string basketId)
        {
            var basket = await _basketRepository.GetCustomerBasket(basketId);
            return Ok(basket ?? new CustomerBasket(basketId));
            // p4.6 go to CustomerBasket to create ctor

        }
        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasket basket)
        {
            var customerBasket = await _basketRepository.UpdateCustomerBasket(basket);
            return Ok(customerBasket);
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> DeleteBasket(string basketId)
        => await _basketRepository.DeleteCustomerBasket(basketId);

        // p4.7 download redis server

    }
}
