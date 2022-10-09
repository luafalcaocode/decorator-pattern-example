using System;
using System.Collections.Generic;
using System.Text;

namespace decorator_example_products
{
    public abstract class ProductDecorator : ProductComponent
    {
        private ProductComponent component;

        public ProductDecorator(ProductComponent component) => this.component = component;

        public override double Price()
        {
            return this.component.Price();
        }
    }
}
