using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO.Entities.ExeercicioEC
{
    class Productt
    {
        public string Name { get; set; }
        public double Price { get; private set; }

        public Productt(string name, double price) 
        {
            Name = name;
            Price = price;
        }
    }
}
