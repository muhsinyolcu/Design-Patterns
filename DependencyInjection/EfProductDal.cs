using System;

namespace DependencyInjection
{
    class EfProductDal: IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with EF");
        }
    }
}
