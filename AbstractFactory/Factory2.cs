using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Factory2 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            return new NLogger();
        }
    }
}
