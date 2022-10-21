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
            double sum = BaseSalary;

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
