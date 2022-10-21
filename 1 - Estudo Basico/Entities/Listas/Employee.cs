using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BasicoPOO.Entities.Listas
{
    class Employee
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; private set; }

        public Employee(int id, string nome, decimal salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public decimal AumentoPorcentagem(decimal porcentagem)
        {
            decimal x = 0;

            x = (Salario * porcentagem) / 100;

            return Salario += x;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
