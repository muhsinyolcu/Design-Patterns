using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class CarDecoratorBase : CarBase
    {
        private CarBase _carBase;
        protected CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }
    }
}
