namespace NullObject
{
    class Log4NetLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged with Log4Net");
        }
    }
}
