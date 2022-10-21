using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BasicoPOO.Entities.Contrutores_e_Encapsulamento
{
    class Construtor
    {
        public string Nome;
        public decimal Preco;
        public int Quantidade;

        public Construtor(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }
        public void Quant(int quant)
        {
            Quantidade += quant;
        }

        public decimal precoFinal()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return "Preço: " + precoFinal().ToString("F2", CultureInfo.InvariantCulture) + ", Nome: " + Nome;
        }
    }
}
