﻿using _128_Exercicios_Fixacao.Entities.Exception;

namespace _128_Exercicios_Fixacao.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public Account()
        {

        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount) 
        {
            if(amount > WithdrawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit.");
            }
            if(amount > Balance)
            {
                throw new AccountException("Not enough balance.");
            }

            Balance -= amount;
        }
        public override string ToString()
        {
            return "New balance: "
                + Balance.ToString("F2")
                + ".";
        }
    }
}
