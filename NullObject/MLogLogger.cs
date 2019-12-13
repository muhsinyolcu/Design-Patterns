namespace NullObject
{
    class MLogLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged with MLogLogger");
        }
    }
}
