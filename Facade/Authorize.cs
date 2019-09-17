using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Authorize:IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("User checked");
        }
    }
}
