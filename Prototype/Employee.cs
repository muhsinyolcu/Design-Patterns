using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
