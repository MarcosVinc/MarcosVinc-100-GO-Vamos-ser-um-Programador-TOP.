using System.Globalization;
using System.Text;

namespace IntermediarioPOO._10_Herança_e_Polimorfismo._140__a_142___Exercicios._142
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; protected set; }

        public Product(string name, double price) 
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
        

    }
}
