using System;
using Estudos1.Entities.Enums;


namespace Estudos1.Entities
{
    internal class Worker
    {
        public string Name { get; set; }

        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }

        public List<HourContract> Contract { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract (HourContract contract)
        {
            Contract.Add(contract);
        }
        public void RemoveContract (HourContract contract)
        {
            Contract.Remove(contract);
        }

        public double Income(int month, int year)
        {
            double sum = BaseSalary;

            foreach(HourContract contract in Contract)
            {
                if (contract.Data.Year == year && contract.Data.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
            
        }

    }
}
