using System;
using System.Globalization;

namespace Exercicio7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial: ");
            string depo = Console.ReadLine();
            bool deposito;
            ContaBancaria contaBancaria;
            if (depo == "s")
            {
                deposito = true;
            }
            else
            {
                deposito = false;
            }
            if (deposito)
            {
                Console.Write("Entre o valor de depósito incial: ");
                double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numeroConta, titularConta, valorDeposito);
            }
            else
            {
                contaBancaria = new ContaBancaria(numeroConta, titularConta);
            }
            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            contaBancaria.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();

            Console.Write("Entre um valor para saque:");
            contaBancaria.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(contaBancaria);
        }
    }
}