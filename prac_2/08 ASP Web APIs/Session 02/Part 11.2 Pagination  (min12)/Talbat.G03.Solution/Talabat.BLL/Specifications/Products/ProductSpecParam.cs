using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.BLL.Specifications.Products
{

    public class ProductSpecParam
    {
        // ... p12 coming from FileText.cs
        // p12.1 add prop for PageIndex full prop to PageSize

        // - set MaxPage Size
        private const int MaxPageSize = 50;
        public int PageIndex { get; set; } = 1; // default if we dont set PageIndex

        private int pageSize = 4;// default if we dont set pageSize
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value > MaxPageSize ? MaxPageSize : value; }
        }

        //p12.2 go to ISpecification to add Take and Skip (Pagination Steps)



        public string Sort { get; set; }
        public int? BrandId { get; set; }
        public int? TypeId { get; set; }
    }
    
}
