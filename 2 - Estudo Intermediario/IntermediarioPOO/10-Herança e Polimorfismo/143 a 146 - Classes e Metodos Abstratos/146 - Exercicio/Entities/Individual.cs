using IntermediarioPOO._10_Herança_e_Polimorfismo._143_a_146___Classes_e_Metodos_Abstratos._146____Exercicio_Abastrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO._10_Herança_e_Polimorfismo._143_a_146___Classes_e_Metodos_Abstratos._146___Exercicio.Entities
{
    class Individual : Contribuintes
    {
        public double GastosMedicos { get; set; }

        public Individual(string nome, double ganhoAnual,double gastosMedicos)
        : base(nome, ganhoAnual)
        {
            GastosMedicos = gastosMedicos;
        }

        public override double Taxa()
        {
            double ImpostoMaior = 0.25;
            double ImpostoBase = 0.15;
            double taxaMedica = 0.5;
            double result = 0;

            if (GanhoAnual < 20000)
            {
                if (GastosMedicos <= 0)
                {
                    result += GanhoAnual * taxaMedica;
                }
                else
                {
                    result += (GanhoAnual * ImpostoBase) - (GastosMedicos * taxaMedica);
                }
            }
            else 
            {
                if (GastosMedicos <= 0)
                {
                    result += GanhoAnual * taxaMedica;

                }
                else
                {
                    result += (GanhoAnual * ImpostoMaior) - (GastosMedicos * taxaMedica);
                }

            }
            return result;
        }
    }



}
