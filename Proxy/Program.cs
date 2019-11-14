using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditBase manager = new CreditManagerProxy();
            Console.WriteLine(manager.Calculate());
            Console.WriteLine(manager.Calculate());

            Console.ReadLine();
        }
    }
}
