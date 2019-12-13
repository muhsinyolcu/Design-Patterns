using System;

namespace Visitor
{
    class OrganitionalStructure
    {
        private EmployeeBase Employee;
        public OrganitionalStructure(EmployeeBase firstEmployee)
        {
            Employee = firstEmployee;
        }
        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);
        }

        public void Accept(PayrollVisitor payrollVisitor)
        {
            Employee.Accept(payrollVisitor);
        }
    }
}
