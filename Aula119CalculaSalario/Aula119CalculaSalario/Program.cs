using Aula119CalculaSalario.Entities;
using Aula119CalculaSalario.Entities.Enums;
using System;

namespace Aula119CalculaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department´s name: ");
            string department = Console.ReadLine();

            Console.WriteLine("Enter worker data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level, escolha 1 para Junior 2 para MidLevel e 3 para Senior): ");
            string level = Console.ReadLine();
            WorkerLevel workerLevel;
            if (level == "1")
            {
                workerLevel = WorkerLevel.Junior;
            }
            else if (level == "2")
            {
                workerLevel = WorkerLevel.MidLevel;
            }
            else
            {
                workerLevel = WorkerLevel.Senior;
            }

            Console.Write("Base salary: ");
            double bSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(department);
            Worker worker = new Worker(name, workerLevel, bSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int nContracts = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nContracts; i++)
            {
                Console.WriteLine("Enter #" + i + " contract data");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueHours = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine();
                HourContract contract = new HourContract(date, valueHours, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY):");
            string period = Console.ReadLine();
            int month = int.Parse(period.Substring(0, 2));//pega os 2 primeiros caracters
            int year = int.Parse(period.Substring(3));//pega do 3 em diante
            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Department.Name);
            Console.WriteLine("Salário: " + worker.Income(year, month).ToString("f2"));
        }
    }
}
