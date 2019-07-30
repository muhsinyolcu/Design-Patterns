namespace FactoryMethod
{
    class MYLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged with MYLogger");
        }
    }
}
