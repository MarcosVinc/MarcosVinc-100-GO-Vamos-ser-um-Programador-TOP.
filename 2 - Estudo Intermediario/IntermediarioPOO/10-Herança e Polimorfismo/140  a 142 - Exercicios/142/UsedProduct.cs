using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace IntermediarioPOO._10_Herança_e_Polimorfismo._140__a_142___Exercicios._142
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get;  private set; }

        public UsedProduct(string name, double price, DateTime facturedate)
        :base(name, price) 
        {
            ManufactureDate = facturedate;
        }
        public override string priceTag()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} (used) $ " +
            $"{Price.ToString("F2", CultureInfo.InvariantCulture)} " +
            $"(Manufacture date: {ManufactureDate.ToString()})");
            return sb.ToString();
        }
    }
}
