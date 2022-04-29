using System;
using Exercicio8.Entities.Exceptions;
using Exercicio8.Entities;
using System.Globalization;

namespace Exercicio8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter account data:");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.Write("\nEnter amount for withdraw: ");
            double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(withdrawAmount);

                Console.WriteLine($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (ExceedsWithdrawLimitException e)
            {
                Console.WriteLine(e);
            }
            catch (NotEnoughBalanceException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}