using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerObserver = new CustomerObserver();
            var employeeObserver = new EmployeeObserver();

            ProductManager productManager = new ProductManager();

            productManager.Attach(customerObserver);
            productManager.Attach(employeeObserver);

            productManager.Detach(customerObserver);
            productManager.Detach(employeeObserver);

            productManager.UpdatePrice();

            Console.ReadLine();
        }
    }
}
