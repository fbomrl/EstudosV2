using _100_ExercicioFixacao_Enum_Composicao.Entities;
using System;
using System.Globalization;

namespace _100_ExercicioFixacao_Enum_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter department's name: ");
            string dptName = Console.ReadLine();
            Console.WriteLine("Enter Worker data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            //WorkLevelEnum level = Enum.Parse<WorkLevelEnum>(Console.ReadLine());
            WorkLevelEnum level = (WorkLevelEnum)Enum.Parse(typeof(WorkLevelEnum), Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(dptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
            Console.Write($"Enter #{i} contract data: ");
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Duration (hours): ");
            int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date,valuePerHour,hours);
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(0, 3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {year}: {month}");

        }
    }
}
