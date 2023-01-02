
using System;
using System.Globalization;

namespace Exercicio.Entities
{
    class Installment
    {
        public DateTime DueData { get; set; }
        public double Amount { get; protected set; }

        public Installment(DateTime dueData, double amount)
        {
            DueData = dueData;
            Amount = amount;
        }
        public override string ToString()
        {
            return DueData.ToString("dd/MM/yyyy")
                + " - "
                +Amount.ToString("F2", CultureInfo.InvariantCulture)
                
                ;
        }
    }
}
