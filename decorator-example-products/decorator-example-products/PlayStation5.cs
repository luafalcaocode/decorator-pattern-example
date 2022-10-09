using System;
using System.Collections.Generic;
using System.Text;

namespace decorator_example_products
{
    public class PlayStation5 : ProductComponent
    {
        public override double Price()
        {
            // isto poderia ser substituído por um acesso ao banco de dados ou chamada de API
            return 5545.55;
        }
    }
}
