using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new MLogLogger());
            customerManager.Save();
        }
    }
}
