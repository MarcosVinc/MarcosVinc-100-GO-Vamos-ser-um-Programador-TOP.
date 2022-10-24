using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO.Entities.ExeercicioEC
{
    class OrderItem
    {
        public int Quantity { get;  private set; }
        public double Price { get;  private set; }
        public Productt Product { get; set; }

        public OrderItem(int quantity, double price, Productt productt) 
        {
            Quantity = quantity;
            Price = price;
            Product = productt;
        }

        public double SubTotal() 
        {
            double sum = 0.0;

            sum = Quantity * Price;

            return sum;

        }
    }
}
