using System;
using System.Collections.Generic;
using Aula119CalculaSalario.Entities.Enums;

namespace Aula119CalculaSalario.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }//Composição class Departments
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();//Composição lista class HourContract
        //Deve-se garantir que a lista não seja nula, new List<HourContract>()
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {//por regra as listas não entram no construtor, relação de 1 para muitos
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
