using _119_Exercicio_proposto_metodos_abstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _119_Exercicio_proposto_metodos_abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int nOfEmplyees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Company(name, anualIncome, nOfEmplyees));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("TAX PAID:");
            foreach (TaxPayer tp in list)
            {
                Console.WriteLine($"{tp.Name}: $ {tp.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine();

            double sum = 0.0;
            foreach(TaxPayer tx in list)
            {
                sum += tx.Tax();
            }
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");



            Console.ReadLine();
        }
    }
}
