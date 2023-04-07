using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoDesenvolvimento.Pergunta4.Entities
{
    public class Bill
    {
        public DateTime DueDate { get; set; }
        public Decimal Value { get; set; }
        public Decimal Interest { get; set; } = Decimal.Zero;

        public Bill(DateTime dueDate, decimal value)
        {
            DueDate = dueDate;
            Value = value;
        }

        public void SetPayment(DateTime paymentDate)
        {
            if (DueDate < paymentDate)
            {
                if (DayFunctions.CheckWeekend(DueDate) || DayFunctions.CheckHoliday(DueDate))
                {
                    DateTime nextBusinessDay = DayFunctions.NextBusinessDay(DueDate);

                    if (nextBusinessDay < paymentDate)
                    {
                        Interest += (0.03m * GetDaysLate(paymentDate)) + 2;
                        DueDate = paymentDate;
                    }
                    else
                    {
                        DueDate = paymentDate;
                    }
                }
                else
                {
                    Interest += (0.03m * GetDaysLate(paymentDate)) + 2;
                    DueDate = paymentDate;
                }
            }
            else
            {
                DueDate = paymentDate;
            }

            Value += Interest;
        }

        int GetDaysLate(DateTime paymentDate)
        {
            if (DueDate < paymentDate)
                return (paymentDate - DueDate).Days;

            return 0;
        }

        public override string ToString()
        {
            return $"Vencimento do boleto: {DueDate.ToString("dd/MM/yyyy")}\n" +
                $"Multas: $ {Interest.ToString("F2")}\n" +
                $"Valor total: $ {Value.ToString("F2")}";
        }
    }
}
