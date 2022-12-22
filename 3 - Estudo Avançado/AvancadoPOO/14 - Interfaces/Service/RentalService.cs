using AvancadoPOO._14___Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvancadoPOO._14___Interfaces.Service
{
    class RentalService
    {
        public double PricePerHour { get;  private set; }
        public double PricePerDay { get; private set; }

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental) 
        { 
        
        }
    }
}
