using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Entities;
using Services;

namespace Exercicio2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"G:\Cursos\CursoCSHarp\Exercicios\avancado\Exercicio2\Exercicio2\Input\Input.csv";
            List<Employee> employees = new List<Employee>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(",");
                        employees.Add(new Employee(fields[0], fields[1], double.Parse(fields[2], CultureInfo.InvariantCulture)));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Enter full file path: " + path);
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Email of people whose salary is more than " + salary.ToString("F2", CultureInfo.InvariantCulture));
            Print(EmployeeService.ListOfEmailsWithSalaryHigher(employees, salary));
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + EmployeeService.SumOfSalaryThatStartsWithM(employees).ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void Print(IEnumerable<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}