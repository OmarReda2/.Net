using System.Collections.Generic;

namespace Demo.Errors
{
    public class ApiValiditionErrorResponse: ApiException
    {
        public ApiValiditionErrorResponse():base(400)
        {

        }

        public IEnumerable<string> Errors { get; set; }
    }
}
