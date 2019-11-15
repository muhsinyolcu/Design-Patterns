using System;

namespace Observer
{
    class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to employee: Product price updated");
        }
    }
}
