using System;
using System.Collections.Generic;
using System.Text;

namespace AvancadoPOO._14___Interfaces.Service
{
    class BrazilTax : ITaxService
    {

        public double Tax(double amount) 
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else 
            {
                return amount * 0.15;
            }       
        }
    }
}
