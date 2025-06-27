using _116_117_Classes_Metodos_Abstratas.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _116_117_Classes_Metodos_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CLASSES ABSTRATAS
            //        São classes que não podem ser instanciadas
            //        É uma forma de garantir herança total: somente subclasses não abstratas podem ser instanciadas, mas nunca a superclasse abstrata;
            // Obs: Notação UML: Itálico

            //Não pode criar uma instância da classe que é abstrata (CS0144)
            //Account acc1 = new Account(1001, "Alex", 500.0);


            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Total balace: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            foreach(Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            Console.WriteLine();
            foreach (Account acc in list)
            {
                Console.WriteLine("Update balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)
                    );
            }
            #endregion

            #region METODOS ABSTRATOS

            //São métodos que não possuem implementação
            //Métodos precisam ser abstratos quando a classe é genérica demais para conter sua implementação
            //Se uma classe possuir pelo menos um método abstrato, então esta classe também é abstrata;
            //Obs: Notação UML: Itálico;

            #endregion

            Console.ReadLine();


        }
    }
}
