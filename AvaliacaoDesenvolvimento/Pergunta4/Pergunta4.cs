using AvaliacaoDesenvolvimento.Application;
using AvaliacaoDesenvolvimento.Pergunta4.Entities;
using System.Globalization;

namespace AvaliacaoDesenvolvimento.Pergunta4
{
    public class Pergunta4 : IPergunta
    {
        public void Execute()
        {
            string response = string.Empty;

            do
            {
                Bill bill = ReadBill();

                bill.SetPayment(ReadPayment());

                PrintBill(bill);

                Console.Write("Deseja continuar (s/N)? ");
                response = Console.ReadLine().ToUpper();

            } while (response != "N");
        }

        void PrintBill(Bill bill)
        {
            Console.Clear();

            Console.WriteLine(bill);

            Console.WriteLine("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        DateTime ReadPayment()
        {
            Console.Write("Data de pagamento do boleto(dd/MM/yyyy): ");
            DateTime date = Convert.ToDateTime(DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture));

            return date;
        }

        Bill ReadBill()
        {
            Console.Clear();

            Console.Write("Valor do boleto: $ ");
            Decimal value = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Data de vencimento original do boleto (dd/MM/yyyy): ");
            DateTime date = Convert.ToDateTime(DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture));

            return new Bill(date, value);
        }
    }
}
