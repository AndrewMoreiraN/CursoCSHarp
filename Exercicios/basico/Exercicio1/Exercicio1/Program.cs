using System;
using System.Globalization;

namespace Exercicio1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"Exercício 1:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Exercicio1());
            }

            Console.WriteLine($"\nExercício 2:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Exercicio2());
            }

            Console.WriteLine($"\nExercício 3:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Exercicio3());
            }
            Console.WriteLine($"\nExercício 4:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Exercicio4());
            }

            Console.WriteLine($"\nExercício 5:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Exercicio5());
            }

            Console.WriteLine($"\nExercício 6:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Exercicio6());
            }
        }

        private static String Exercicio1()
        {
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());

            return $"\tSOMA = {numero1 + numero2}\n";
        }

        private static String Exercicio2()
        {
            double raio = double.Parse(Console.ReadLine());

            return $"\tA = {(3.14159 * Math.Pow(raio, 2)).ToString("F4", CultureInfo.InvariantCulture)}\n";
        }

        private static String Exercicio3()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            return $"\tDIFERENÇA = {a * b - c * d}\n";
        }

        private static String Exercicio4()
        {
            int number = int.Parse(Console.ReadLine());
            int hoursWorked = int.Parse(Console.ReadLine());
            float salaryPerHour = float.Parse(Console.ReadLine());

            return $"\tNUMBER = {number}\n\tSALARY = U$ {(hoursWorked * salaryPerHour).ToString("F2", CultureInfo.InvariantCulture)}";
        }

        private static String Exercicio5()
        {
            string[] string1 = Console.ReadLine().Split(' ');
            string[] string2 = Console.ReadLine().Split(' ');
            int code1 = int.Parse(string1[0]);
            int code2 = int.Parse(string2[0]);
            int number1 = int.Parse(string1[1]);
            int number2 = int.Parse(string2[1]);
            float price1 = float.Parse(string1[2]);
            float price2 = float.Parse(string2[2]);

            return $"\tVALOR A PAGAR: R$ {(number1 * price1 + number2 * price2).ToString("F2", CultureInfo.InvariantCulture)}";
        }

        private static String Exercicio6()
        {
            string[] string1 = Console.ReadLine().Split(' ');
            float a = float.Parse(string1[0]);
            float b = float.Parse(string1[1]);
            float c = float.Parse(string1[2]);

            return $"\tTRIANGULO: {(a * c / 2).ToString("F3", CultureInfo.InvariantCulture)}\n" +
                    $"\tCIRCULO: {(Math.Pow(c, 2) * 3.14159).ToString("F3", CultureInfo.InvariantCulture)}\n" +
                    $"\tTRAPEZIO: {((a + b) / 2 * c).ToString("F3", CultureInfo.InvariantCulture)}\n" +
                    $"\tQUADRADO: {(Math.Pow(b, 2)).ToString("F3", CultureInfo.InvariantCulture)}\n" +
                    $"\tRETANGULO: {(a * b).ToString("F3", CultureInfo.InvariantCulture)}\n";
        }
    }
}