using IntermediarioPOO._10_Herança_e_Polimorfismo._143_a_146___Classes_e_Metodos_Abstratos._146___Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO._10_Herança_e_Polimorfismo._143_a_146___Classes_e_Metodos_Abstratos._146____Exercicio_Abastrato
{
    abstract class Contribuintes
    {
        public string  Nome { get; set; }
        public double  GanhoAnual { get; protected set; }


        public Contribuintes(string nome, double ganhoAnual) 
        {
            Nome = nome;
            GanhoAnual = ganhoAnual;
        }

        public abstract double Taxa();

    }
}
