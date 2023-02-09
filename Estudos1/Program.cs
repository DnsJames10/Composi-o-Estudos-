using System;
using Estudos1.Entities;
using Estudos1.Entities.Enums;
using System.Globalization;


namespace Estudos1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departamet 's name: ");
            string departament = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Worker data: ");
            Console.Write("Level (Junior/MidLevel/Senior: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Departament depar = new Departament(departament);           
            Worker worker = new Worker(name,level,salary, depar);

            Console.WriteLine();
            Console.WriteLine("How Many contracts to this worker");
            int qte = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------");
            Console.WriteLine();
            for (int i = 1; i <= qte; i++)
            {
                Console.WriteLine($"Enter {i} contract data: ");
                Console.Write("Date (MM/DD/YYYY): ");
                DateTime date= DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration: ");
                int hour = int.Parse(Console.ReadLine());

                HourContract Contract = new HourContract(date, valueperhour, hour);
                worker.Contract.Add(Contract);
                
            }

            Console.WriteLine();
            Console.WriteLine("Enter month end year to calculate income (MM/YYYY): ");
            string monye = Console.ReadLine();
            int month = int.Parse(monye.Substring(0, 2));
            int year = int.Parse(monye.Substring(3, 4));
            
            Console.Write("Name: "+ worker.Name);
            Console.Write("Departament: " + worker.Departament.Name);
            Console.Write("Income:  " + worker.Income(month, year).ToString("f2"), CultureInfo.InvariantCulture);
            


        }

    }
}

