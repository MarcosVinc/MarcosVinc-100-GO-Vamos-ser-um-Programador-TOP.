
using System;
using System.Collections.Generic;

namespace Exercicio.Entities
{
    class Contract
    {
        public int number { get;  protected set; }
        public DateTime  dateTime { get;  protected set; }
        public double totalValue { get; protected set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime DateTime, double totalValue)
        {
            this.number = number;
            dateTime = DateTime;
            this.totalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

    }
}
