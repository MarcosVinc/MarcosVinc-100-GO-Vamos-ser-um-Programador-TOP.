using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO.Entities
{
    class HourContract
    {
        public DateTime Date { get; private set; }
        public double valuePerHour { get; private set; }
        public int hours { get; private set; }

        public HourContract() { }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.Date = date;
            this.valuePerHour = valuePerHour;
            this.hours = hours;
        }

        public double totalValue()
        {
            return hours * valuePerHour;

        }
    }
}
