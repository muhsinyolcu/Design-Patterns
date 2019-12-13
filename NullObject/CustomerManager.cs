namespace NullObject
{
    class CustomerManager
    {
        private ILogger _logger;
        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Save()
        {
            System.Console.WriteLine("Saved");
            _logger.Log();
        }
    }
}
