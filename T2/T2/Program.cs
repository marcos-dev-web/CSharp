using System;
using System.Globalization;
using T2.Entities;
using T2.Entities.Enums;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            Console.Write("Enter department's name: ");
            worker.Department.Name = Console.ReadLine();
            Console.Write("Enter worker data: \n");
            Console.Write("Name: ");
            worker.Name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            worker.Level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            worker.BaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker? ");

            int totalContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalContracts; i++)
            {
                HourContract contract = new HourContract();
                Console.Write($"\nEnter #{i + 1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                contract.Date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                contract.ValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                Console.Write("Duration (hours): ");
                contract.Hours = int.Parse(Console.ReadLine());

                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string date = Console.ReadLine();
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department}");

            int month = int.Parse(date.Split('/')[0]);
            int year = int.Parse(date.Split('/')[1]);

            double income = worker.Income(year, month);
            Console.WriteLine($"\nIncome for {date}: {income.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
