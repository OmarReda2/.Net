using System.Collections.Generic;
using Talbat.API.DTO;

namespace Talbat.API.Helper
{
    // ... 12.10 coming from SpecificationsEvaluator
    //12.11 add PageIndex, PageSize, Count and Data props
    public class Pagination<T>
    {

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public IReadOnlyList<T> Data { get; set; }
        //12.12 go to ProductController to make the endPoint return Pagination...


        // ... 12.14 coming from ProductController
        // 12.15 add the ctor with the params
        public Pagination(int pageIndex, int pageSize, int count, IReadOnlyList<T> data)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Count = count;
            Data = data;
        }
        //  12.16 return to ProductController..
    }

}
