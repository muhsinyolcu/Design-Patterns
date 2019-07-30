namespace Singleton
{
    class CustomerManager
    {
        private static CustomerManager _customerManager;
        private CustomerManager() { }
        static object _lockObject = new object();
        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }
            return _customerManager;
        }

        public void Save() => System.Console.WriteLine("Saved!!");
    }
}
