namespace AbstractFactory
{
    class NLogger : Logging
    {
        public override void Log(string message)
        {
            System.Console.WriteLine("Logged with nLogger");
        }
    }
}
