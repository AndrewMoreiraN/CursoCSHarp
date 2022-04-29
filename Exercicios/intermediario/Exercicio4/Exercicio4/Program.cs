using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio4.Entities;

namespace Exercicio4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int numberOfEmployee = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfEmployee; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'n')
                {
                    employeeList.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employeeList.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                }
            }
            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee);
            }
        }
    }
}