using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cache with MemCache");
        }
    }
}
