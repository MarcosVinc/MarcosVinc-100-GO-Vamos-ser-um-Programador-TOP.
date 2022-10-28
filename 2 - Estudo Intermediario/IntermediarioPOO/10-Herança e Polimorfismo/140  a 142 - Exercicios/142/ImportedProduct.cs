using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace IntermediarioPOO._10_Herança_e_Polimorfismo._140__a_142___Exercicios._142
{
    class ImportedProduct : Product
    {
        public double customsFee { get;  private set; }

        public ImportedProduct(string name, double price, double customs)
        : base(name, price)
        {
            customsFee = customs;
        }
        public override string priceTag()
        {
            double sum = Price + customsFee;

            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} $ " +
            $"{sum.ToString("F2", CultureInfo.InvariantCulture)} " +
            $"(Customs fee: $ {customsFee.ToString("F2")})");
            return sb.ToString();

        }
    }
}
