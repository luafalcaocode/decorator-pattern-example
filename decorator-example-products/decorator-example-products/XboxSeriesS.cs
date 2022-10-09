using System;
using System.Collections.Generic;
using System.Text;

namespace decorator_example_products
{
    public class XboxSeriesS : ProductComponent
    {
        public override double Price()
        {
            return 2128.00;
        }
    }
}
