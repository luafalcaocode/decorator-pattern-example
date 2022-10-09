using System;

namespace decorator_example_products
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductComponent ps5 = new PlayStation5();
            ProductComponent xbox = new XboxSeriesS();

            Console.WriteLine("Preço original do PlayStation 5: {0:C}", ps5.Price());
            Console.WriteLine("Preço original do Xbox Series S: {0:C}", xbox.Price());

            ProductDecorator ps5ComFreteEspecial = new FreteEspecialDecorator(ps5);
            ProductDecorator xboxComCupomDesconto = new CupomDescontoDecorator(xbox);

            Console.WriteLine();

            Console.WriteLine("Preço do PlayStation 5 com frete especial: {0:C}", ps5ComFreteEspecial.Price());
            Console.WriteLine("Preço do Xbox Series S com cupom de desconto: {0:C}", xboxComCupomDesconto.Price());
        }
    }
}
