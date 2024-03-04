using System;
using System.Collections.Generic;
using System.Globalization;

namespace _078_ExerciciosFixacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employyees will be registered? ");
            int quantity = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Employee #" + i + " :");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary U$ ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id hat will have salary increase: ");
            int searchID = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchID);
            if (emp != null)
            {
                Console.Write("enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees: ");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}