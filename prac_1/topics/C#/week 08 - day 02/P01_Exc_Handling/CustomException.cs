using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Exc_Handling
{
    internal class CustomException:Exception
    {
        public CustomException():base("Message of Custom Exception")
        {

        }
    }
}
