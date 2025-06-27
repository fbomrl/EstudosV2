using _128_Exercicios_Fixacao.Entities;
using _128_Exercicios_Fixacao.Entities.Exception;
using System;

namespace _128_Exercicios_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double InitBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double WithdrawLimit = double.Parse(Console.ReadLine());
                Account account = new Account(number, holder, InitBalance, WithdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
                Console.Write(account);
            }
            catch(AccountException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
