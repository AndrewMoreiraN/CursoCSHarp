using System;
using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Exercicio1:\n");
            Console.WriteLine(Exercicio1());
            Console.WriteLine(Exercicio1());
            Console.WriteLine(Exercicio1());

            Console.WriteLine("\nExercicio2:\n");
            Console.WriteLine(Exercicio2());
            Console.WriteLine(Exercicio2());
            Console.WriteLine(Exercicio2());

            Console.WriteLine("\nExercicio3:\n");
            Console.WriteLine(Exercicio3());
            Console.WriteLine(Exercicio3());
            Console.WriteLine(Exercicio3());

            Console.WriteLine("\nExercicio4:\n");
            Console.WriteLine(Exercicio4());
            Console.WriteLine(Exercicio4());
            Console.WriteLine(Exercicio4());

            Console.WriteLine("\nExercicio5:\n");
            Console.WriteLine(Exercicio5());
            Console.WriteLine(Exercicio5());

            Console.WriteLine("\nExercicio6:\n");
            Console.WriteLine(Exercicio6());
            Console.WriteLine(Exercicio6());
            Console.WriteLine(Exercicio6());
            Console.WriteLine(Exercicio6());

            Console.WriteLine("\nExercicio7:\n");
            Console.WriteLine(Exercicio7());
            Console.WriteLine(Exercicio7());
            Console.WriteLine(Exercicio7());

            Console.WriteLine("\nExercicio8:\n");
            Console.WriteLine(Exercicio8());
            Console.WriteLine(Exercicio8());
            Console.WriteLine(Exercicio8());
        }

        private static String Exercicio1()
        {
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 0)
            {
                return "\tPOSITIVO\n";
            }
            else
            {
                return "\tNEGATIVO\n";
            }
        }

        private static String Exercicio2()
        {
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                return "\tPAR\n";
            }
            else
            {
                return "\tIMPAR\n";
            }
        }

        private static String Exercicio3()
        {
            string[] s = Console.ReadLine().Split(" ");
            int numero1 = int.Parse(s[0]);
            int numero2 = int.Parse(s[1]);
            if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
            {
                return "\tSao Multiplos\n";
            }
            else
            {
                return "\tNao sao Multiplos\n";
            }
        }

        private static String Exercicio4()
        {
            string[] s = Console.ReadLine().Split(" ");
            int numero1 = int.Parse(s[0]);
            int numero2 = int.Parse(s[1]);
            if (numero1 > numero2 || numero2 == numero1)
            {
                numero2 += 24;
            }
            return $"\tO JOGO DUROU {numero2 - numero1} HORA(S)\n";
        }

        private static String Exercicio5()
        {
            string[] s = Console.ReadLine().Split(" ");
            int codigo = int.Parse(s[0]);
            int quantidade = int.Parse(s[1]);
            float preco;
            if (codigo == 1)
                preco = 4f;
            else if (codigo == 2)
                preco = 4.5f;
            else if (codigo == 3)
                preco = 5f;
            else if (codigo == 4)
                preco = 2f;
            else
                preco = 1.5f;
            return $"\tTotal: R$ {(quantidade * preco).ToString("F2", CultureInfo.InvariantCulture)}\n";
        }

        private static String Exercicio6()
        {
            float valor = float.Parse(Console.ReadLine());
            if (valor >= 0 && valor <= 25)
                return "\tIntervalo [0,25]\n";
            else if (valor > 25 && valor <= 50)
                return "\tIntervalo (25,50]\n";
            else if (valor > 50 && valor <= 75)
                return "\tIntervalo (50,75]\n";
            else if (valor > 75 && valor <= 100)
                return "\tIntervalo (75,100]\n";
            else
                return "\tFora de intervalo\n";
        }

        private static String Exercicio7()
        {
            string[] s = Console.ReadLine().Split(" ");
            float v1 = float.Parse(s[0]);
            float v2 = float.Parse(s[1]);
            if (v1 > 0 && v2 == 0)
                return "\tEixo X\n";
            else if (v2 > 0 && v1 == 0)
                return "\tEixo Y\n";
            else if (v1 >= 0 && v2 >= 0)
                return "\tQ1\n";
            else if (v1 >= 0 && v2 <= 0)
                return "\tQ4\n";
            else if (v1 <= 0 && v2 <= 0)
                return "\tQ3\n";
            else if (v1 <= 0 && v2 >= 0)
                return "\tQ2\n";
            else
                return "\tOrigem\n";
        }

        private static String Exercicio8()
        {
            float salario = float.Parse(Console.ReadLine());
            float imposto = 0;
            if (salario <= 2000)
            {
                return "\tIsento\n";
            }
            else if (salario > 2000 && salario <= 3000)
            {
                return $"\tR$ {(salario % 2000 * 0.08).ToString("F2", CultureInfo.InvariantCulture)}\n";
            }
            else if (salario > 3000 && salario <= 4500)
            {
                return $"\tR$ {(salario % 3000 * 0.18 + 80).ToString("F2", CultureInfo.InvariantCulture)}\n";
            }
            else
            {
                return $"\tR$ {(salario % 4500 * 0.28 + 80 + 270).ToString("F2", CultureInfo.InvariantCulture)}\n";
            }
        }
    }
}