using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO._10_Herança_e_Polimorfismo._140__a_142___Exercicios._140
{
    class OutsourcedEmployee : Employee
    {
        public double AddicionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addicionalcharger) : base(name, hours, valuePerHour) 
        {
            AddicionalCharge = addicionalcharger;
        }

        public override double payment()
        {
            return base.payment() + 1.1 * AddicionalCharge;
        }
    }
}
