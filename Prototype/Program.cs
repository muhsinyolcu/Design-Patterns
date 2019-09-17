using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Muhsin", LastName = "Yolcu", City = "İstanbul" };

            Customer customer2 = (Customer)customer1.Clone();
            customer2.FirstName = "Albert";

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
        }
    }
}
