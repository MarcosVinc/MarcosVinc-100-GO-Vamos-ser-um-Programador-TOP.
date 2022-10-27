using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO._10_Herança_e_Polimorfismo._140__a_142___Exercicios._140
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; protected set; }
        public double ValuePerHour { get;  protected set; }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double payment() 
        {
            return Hours * ValuePerHour;
        }
    }
}
