using System;
using System.Collections.Generic;
using System.Text;

namespace BasicoPOO.Entities.Classes
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;

        }
        public void AumentarSalario(double porcentagem)
        {

            SalarioBruto = SalarioBruto + (SalarioLiquido() * porcentagem) / 100;

        }

        public override string ToString()
        {
            return $"Funcionário: {Nome}, $ {SalarioLiquido()}";
        }
    }
}
