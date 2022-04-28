using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo invC = CultureInfo.InvariantCulture;

            Console.Write("How many employees will be registered? ");
            int number = int.Parse(Console.ReadLine());

            List<Employee> listOfEmployee = new List<Employee>();

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), invC);
                listOfEmployee.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increased: ");
            int idSalary = int.Parse(Console.ReadLine());

            Employee employ = listOfEmployee.Find(x => x.Id == idSalary);
            if (employ == null)
            {
                Console.WriteLine("This id does not exist!\n");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                float percentageSalary = float.Parse(Console.ReadLine(), invC);
                employ.IncreaseSalary(percentageSalary);
            }
            Console.WriteLine("Updated list of employees:");
            foreach (var item in listOfEmployee)
            {
                Console.WriteLine(item);
            }
        }
    }
}