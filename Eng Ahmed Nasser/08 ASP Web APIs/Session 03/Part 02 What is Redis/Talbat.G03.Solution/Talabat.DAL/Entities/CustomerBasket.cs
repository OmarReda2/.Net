using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.DAL.Entities
{
    // ... p2.3
    public class CustomerBasket
    {
        public string Id { get; set; }
        public List<BasketItem> Items { get; set; }
    }
    //p2.4 install StackExchange.Redis in DAL
    //p2.5 go to Startup to allow DI ...
}
