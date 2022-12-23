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

        private BrazilTax _brazilTax = new BrazilTax();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental) 
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else 
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTax.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
