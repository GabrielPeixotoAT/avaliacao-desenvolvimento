using AvaliacaoDesenvolvimento.Pergunta1.Entities;

namespace AvaliacaoDesenvolvimento.Pergunta1.Discounts.Interfaces
{
    public interface ICarDiscountHandler
    {
        int Total { get; }

        void SetNextDiscount(ICarDiscountHandler discount);
        Decimal Handle(Car car);
    }
}
