using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuartoFiles
{
    internal class Stream_Writer
    {
        public static void Exec(string path, string targetPath)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}