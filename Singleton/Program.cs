namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var cm = CustomerManager.CreateAsSingleton();
            cm.Save();
        }
    }
}
