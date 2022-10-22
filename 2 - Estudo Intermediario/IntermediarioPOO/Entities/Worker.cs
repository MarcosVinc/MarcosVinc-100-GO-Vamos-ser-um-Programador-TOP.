using IntermediarioPOO.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO.Entities
{
    class Worker
    {
        #region Propriedades Auto Implementadas
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; private set; }

        //COMPOSIÇÃO
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        //
        #endregion

        #region Constrotores


        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            this.Name = name;
            this.Level = level;
            this.BaseSalary = baseSalary;
            this.Departament = departament;
        }
        #endregion

        #region Propriedades Customizadas
        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);

        }
        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double income(int year, int month)
        {
            // A variavel sum "soma", recebe o salario base. Ja que o trabalhador 
            // vai receber-lo mesmo sem ter feito contratos adicionais além do que
            // esta em carteira.
            double sum = BaseSalary;

            // Aqui faço um foreach para procurar um contrato, no meu objero Contracts
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }


            }

            return sum;
        }
        #endregion
    }
}
