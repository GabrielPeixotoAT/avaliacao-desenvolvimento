using AvaliacaoDesenvolvimento.Pergunta1.Discounts.Interfaces;
using AvaliacaoDesenvolvimento.Pergunta1.Entities;

namespace AvaliacaoDesenvolvimento.Pergunta1.Discounts
{
    public class Above2000Discount : ICarDiscountHandler
    {
        ICarDiscountHandler nextDicount;
        public int Total { get; private set; }

        public Decimal Handle(Car car)
        {
            if (car.Year > 2000)
            {
                Total++;
                return car.Price * 0.07m;
            }

            return nextDicount.Handle(car);
        }

        public void SetNextDiscount(ICarDiscountHandler nextDicount)
        {
            this.nextDicount = nextDicount;
        }
    }
}
