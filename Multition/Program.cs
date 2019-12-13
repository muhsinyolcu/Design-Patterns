using System;

namespace Multition
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera nikon = Camera.GetCamera("NIKON");
            Camera canon = Camera.GetCamera("CANON");
        }
    }
}
