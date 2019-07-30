namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cm = new CustomerManager(new LoggerFactory());
            cm.Save();
        }
    }
}
