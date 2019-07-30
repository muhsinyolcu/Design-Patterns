using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ProductManager
    {
       private CrossCuttingConcernsFactory _crossCuttingConcernsFactory;
       private Logging _logging;
       private Caching _caching;
        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logging = _crossCuttingConcernsFactory.CreateLogger();
            _caching = _crossCuttingConcernsFactory.CreateCaching();
        }

        public void GetAll()
        {
            _logging.Log("Logged");
            _caching.Cache("Data");
            Console.WriteLine("Products Listed!");
        }
    }
}
