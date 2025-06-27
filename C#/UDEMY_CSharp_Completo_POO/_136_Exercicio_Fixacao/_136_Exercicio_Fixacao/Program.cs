using System;
using System.Globalization;
using System.IO;

namespace _136_Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\fabioms\Desktop\ExFixacao\src.csv";
            string targetPath = @"C:\Users\fabioms\Desktop\ExFixacao\out\summary.csv";
            string final = @"C:\Users\fabioms\Desktop\ExFixacao\out\summary.csv";
            try
            {
                Console.WriteLine("LEITURA INICIAL");
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine();

                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("FINAL");
                using (StreamReader sr = File.OpenText(final))
                {
                    while (!sr.EndOfStream)
                    {
                        var linha = sr.ReadLine();
                        var colunas = linha.Split('\t');

                        string coluna1 = colunas.Length > 0 ? colunas[0] : "";
                        double coluna2 = double.Parse(colunas[1], CultureInfo.InvariantCulture);
                        int coluna3 = int.Parse(colunas[2]);

                        double total = coluna2 * coluna3;
                        
                        Console.WriteLine($"{coluna1}, {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
                Console.WriteLine();
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured.");
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
