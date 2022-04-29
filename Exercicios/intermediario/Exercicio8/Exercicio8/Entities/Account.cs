using System;
using System.Collections.Generic;
using System.Text;
using Exercicio8.Entities.Exceptions;

namespace Exercicio8.Entities
{
    internal class Account
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
            if (amount > Balance)
            {
                throw new NotEnoughBalanceException("Withdraw error: Not enough balance.");
            }
            if (amount > WithdrawLimit)
            {
                throw new ExceedsWithdrawLimitException("Withdraw error: The amount exceeds withdraw limit.");
            }
            Balance -= amount;
        }
    }
}