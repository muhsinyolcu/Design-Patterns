using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Validation : IValidate
    {
        public void Validate()
        {
            Console.WriteLine("Validated");
        }
    }
}
