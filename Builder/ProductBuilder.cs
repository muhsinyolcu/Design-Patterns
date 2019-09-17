using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetModel();
    }
}
