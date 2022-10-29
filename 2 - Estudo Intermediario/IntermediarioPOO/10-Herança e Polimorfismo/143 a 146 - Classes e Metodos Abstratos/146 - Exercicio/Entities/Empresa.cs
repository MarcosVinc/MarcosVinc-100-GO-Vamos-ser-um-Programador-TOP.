using IntermediarioPOO._10_Herança_e_Polimorfismo._143_a_146___Classes_e_Metodos_Abstratos._146____Exercicio_Abastrato;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace IntermediarioPOO._10_Herança_e_Polimorfismo._143_a_146___Classes_e_Metodos_Abstratos._146___Exercicio.Entities
{
    class Empresa : Contribuintes 
    {
        public int  NumerosDeFuncionarios { get; private set; }

        public Empresa(string nome, double ganhoAnual,int numerosDeFuncionarios)
        : base(nome, ganhoAnual)
        {
            NumerosDeFuncionarios = numerosDeFuncionarios;
        }
        public override double Taxa()
        {
            double ImpostoBase = 0.16;
            double ImpostoDesenvolvimentoDoTrabalhador = 0.14;
            double result = 0;

            if (NumerosDeFuncionarios < 10)
            {

                result += GanhoAnual * ImpostoBase;
            }
            else 
            {
                result += GanhoAnual * ImpostoDesenvolvimentoDoTrabalhador;
            }

            return result;


        }
    }
}
