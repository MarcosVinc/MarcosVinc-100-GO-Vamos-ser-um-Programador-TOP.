using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BasicoPOO.Entities.Classes
{
    class Produto
    {
        public string Nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
            Quantidade = 10;
        }
        public Produto(string Nome, double Preco) : this()
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {

            return Preco * Quantidade;

        }
        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString(CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, " + "Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
