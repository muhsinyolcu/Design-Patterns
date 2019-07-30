namespace FactoryMethod
{
    class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new MYLogger();
        }
    }
}
