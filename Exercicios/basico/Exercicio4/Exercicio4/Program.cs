using System;
using System.Globalization;

namespace Exercicio4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1:");
            Exercicio1();
            Console.WriteLine("\nExercício 2:");
            Exercicio2();
            Console.WriteLine("\nExercício 3:");
            Exercicio3();
            Console.WriteLine("\nExercício 4:");
            Exercicio4();
            Console.WriteLine("\nExercício 5:");
            Exercicio5();
            Console.WriteLine("\nExercício 6:");
            Exercicio6();
            Console.WriteLine("\nExercício 7:");
            Exercicio7();
        }

        private static void Exercicio1()
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i += 2)
            {
                Console.WriteLine($"\t{i}");
            }
        }

        private static void Exercicio2()
        {
            int numero = int.Parse(Console.ReadLine());
            int nin = 0;
            int nout = 0;
            for (int i = 0; i < numero; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num >= 10 && num <= 20)
                    nin++;
                else
                    nout++;
            }
            Console.WriteLine($"\t{nin} in");
            Console.WriteLine($"\t{nout} out");
        }

        private static void Exercicio3()
        {
            int numero = int.Parse(Console.ReadLine());
            float media = 0;
            for (int i = 0; i < numero; i++)
            {
                string[] s = Console.ReadLine().Split(" ");
                float n0 = float.Parse(s[0]);
                float n1 = float.Parse(s[1]);
                float n2 = float.Parse(s[2]);
                media = (n0 * 2 + n1 * 3 + n2 * 5) / 100;
                Console.WriteLine($"\t{media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }

        private static void Exercicio4()
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                string[] s = Console.ReadLine().Split(" ");
                if (s[1] == "0")
                    Console.WriteLine("\tdivisao impossivel");
                else
                    Console.WriteLine($"\t{(float.Parse(s[0]) / float.Parse(s[1])).ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }

        private static void Exercicio5()
        {
            int fac = 1;
            int numero = int.Parse(Console.ReadLine());
            if (numero != 0)
            {
                for (int i = numero; i > 0; i--)
                {
                    fac *= i;
                }
            }
            Console.WriteLine($"\t{fac}");
        }

        private static void Exercicio6()
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine($"\t{i}");
                }
            }
        }

        private static void Exercicio7()
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"\t{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}