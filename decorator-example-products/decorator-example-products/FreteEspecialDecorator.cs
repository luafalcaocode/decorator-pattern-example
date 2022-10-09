using System;
using System.Collections.Generic;
using System.Text;

namespace decorator_example_products
{
    public class FreteEspecialDecorator : ProductDecorator
    {
        public FreteEspecialDecorator(ProductComponent component)
            : base(component)
        {

        }

        public override double Price()
        {
            return base.Price() + 25.55;
        }
    }
}
