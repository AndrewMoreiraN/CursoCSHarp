using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Exercicio9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                string originPath = @"G:\Cursos\CursoCSHarp\Exercicios\intermediario\Exercicio9\Files\source_file.csv";
                string targetPath = @"G:\Cursos\CursoCSHarp\Exercicios\intermediario\Exercicio9\Files\summary.csv";
                using (FileStream fs = File.Create(targetPath)) { }
                using (StreamReader sr = File.OpenText(originPath))
                {
                    using (StreamWriter sw = File.AppendText(targetPath))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] s = sr.ReadLine().Split(",");
                            sw.Write($"{s[0]}, {(double.Parse(s[1], CultureInfo.InvariantCulture) * int.Parse(s[2], CultureInfo.InvariantCulture)).ToString("F2", CultureInfo.InvariantCulture)}\n");
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR: ");
                Console.WriteLine(e);
            }
        }
    }
}