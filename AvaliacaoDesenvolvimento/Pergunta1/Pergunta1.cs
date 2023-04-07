using AvaliacaoDesenvolvimento.Application;
using AvaliacaoDesenvolvimento.Pergunta1.Discounts;
using AvaliacaoDesenvolvimento.Pergunta1.Discounts.Interfaces;
using AvaliacaoDesenvolvimento.Pergunta1.Entities;

namespace AvaliacaoDesenvolvimento.Pergunta1
{
    public class Pergunta1 : IPergunta
    {
        public void Execute()
        {
            string response = string.Empty;

            ICarDiscountHandler until2000Discount = new Until2000Discount();
            ICarDiscountHandler above2000Discount = new Above2000Discount();

            until2000Discount.SetNextDiscount(above2000Discount);

            do
            {
                Car car = ReadCar();

                Decimal discount = until2000Discount.Handle(car);

                PrintDiscount(discount, car);

                Console.Write("Deseja continuar (s/N)? ");
                response = Console.ReadLine().ToUpper();

            } while (response != "N");

            FinalPrint(until2000Discount, above2000Discount);
        }

        void FinalPrint(ICarDiscountHandler until2000Discount, ICarDiscountHandler above2000Discount)
        {
            Console.WriteLine($"Total de carros até 2000: {until2000Discount.Total}\n"
                + $"Total Geral de carros: {until2000Discount.Total + above2000Discount.Total}");

            Console.WriteLine("\n\n Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        void PrintDiscount(Decimal discount, Car car)
        {
            Console.WriteLine($"Ano: {car.Year} Preço: {car.Price} Desconto: $ {discount}");
        }

        Car ReadCar ()
        {
            Console.Write("Ano do carro: ");
            string year = Console.ReadLine();

            Console.Write("Preco do carro: $ ");
            string price = Console.ReadLine();
            
            return new Car(int.Parse(year), Decimal.Parse(price));
        }
    }
}
