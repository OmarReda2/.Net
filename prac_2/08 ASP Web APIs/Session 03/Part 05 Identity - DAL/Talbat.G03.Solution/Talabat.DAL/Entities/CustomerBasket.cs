using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.DAL.Entities
{
    public class CustomerBasket
    {
        public string Id { get; set; }
        public List<BasketItem> Items { get; set; }

        // ... p4.6 
        // p4.7
        public CustomerBasket(string id)
        {
            Id = id;
        }
        
    }
}
