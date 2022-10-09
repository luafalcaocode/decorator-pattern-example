using System;
using System.Collections.Generic;
using System.Text;

namespace decorator_example_products
{
    public class CupomDescontoDecorator : ProductDecorator 
    {
        public CupomDescontoDecorator(ProductComponent component)
            : base(component)
        {

        }

        public override double Price()
        {
            return base.Price() - (0.05 * base.Price());
        }
    }
}
