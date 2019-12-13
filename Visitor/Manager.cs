using System.Collections.Generic;

namespace Visitor
{
    class Manager : EmployeeBase
    {
        public Manager()
        {
            SubOrdinates = new List<EmployeeBase>();
        }
        public List<EmployeeBase> SubOrdinates { get; set; } 
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
            foreach (var employee in SubOrdinates)
            {
                employee.Accept(visitor);
            }
        }
    }
}
