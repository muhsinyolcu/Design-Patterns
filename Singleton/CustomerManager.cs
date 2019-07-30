namespace Singleton
{
    class CustomerManager
    {
        private static CustomerManager _customerManager;
        private CustomerManager() { }

        public static CustomerManager CreateAsSingleton()
        {
            return _customerManager ?? (_customerManager = new CustomerManager());
        }

        public void Save() => System.Console.WriteLine("Saved!!");
    }
}
