namespace FactoryMethod
{
    internal interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}