using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio7.Entities;

namespace Exercicio7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            for (int i = 1; i <= numberOfTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char typeOfTaxPayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual revenue: ");
                double anualRevenue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (typeOfTaxPayer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, anualRevenue, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualRevenue, numberOfEmployees));
                }
            }
            Console.WriteLine("\nTAXES PAID:");
            double totalTax = 0;
            foreach (TaxPayer taxPayer in taxPayers)
            {
                totalTax += taxPayer.Tax();
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine($"\nTOTAL TAXES: $ {totalTax.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}