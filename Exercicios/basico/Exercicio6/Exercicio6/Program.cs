using System;
using System.Globalization;

namespace Exercicio6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Exercio 6:");
            Funcionario func = new Funcionario(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine($"\tFuncionário: {func}");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            func.SalarioLiquido(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"\tDados atualizados: {func}");
        }
    }
}