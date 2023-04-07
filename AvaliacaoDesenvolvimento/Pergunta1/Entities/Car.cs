    using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoDesenvolvimento.Pergunta1.Entities
{
    public class Car
    {
        public int Year { get; private set; }
        public Decimal Price { get; private set; }

        public Car(int year, Decimal price) 
        {
            Year = year;
            Price = price;
        }
    }
}
