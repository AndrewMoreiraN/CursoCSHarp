using System;
using System.IO;
using System.Reflection;

namespace Files
{
    internal class FillStream_StreamReader
    {
        public static void Exec(string sourcePath, string targetPath)
        {
            ///FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //FileInfo fileInfo = new FileInfo(sourcePath);
                //string[] lines = File.ReadAllLines(sourcePath);
                //foreach (string line in lines)
                //{
                //    Console.WriteLine(line);
                //}

                ///fs = new FileStream(sourcePath, FileMode.Open);
                //sr = new StreamReader(fs);

                sr = File.OpenText(sourcePath);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}