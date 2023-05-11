using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_First2.Entities
{
    public partial class SalesByCategoryResult
    {
        public override string ToString()
        => $"{this.ProductName} :: {this.TotalPurchase} ";
    }
}
