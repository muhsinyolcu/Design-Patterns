using System;

namespace Facade
{
    class CustomerManager
    {
        CrossCuttingConcernsFacade _concerns;

        public CustomerManager()
        {
            _concerns = new CrossCuttingConcernsFacade();
        }

        public void Save()
        {
            _concerns.Caching.Cache();
            _concerns.Authorize.CheckUser();
            _concerns.Logging.Log();
            _concerns.Validate.Validate();
            Console.WriteLine("Saved!");
        }
    }
}
